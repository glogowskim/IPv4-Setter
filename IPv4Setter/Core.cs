using System.Linq;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace IPv4Setter
{
    static class Core
    {
        //Arguments to command prompt which are used to set DHCP or Static IP
        private static string dhcp;
        private static string staticIp;

        //Flag containing info if the program runs in edit mode (allows user to edit IP settings)
        private static bool editMode = false;

        //Some obvious variables
        private static string configPath = "config.cfg";
        private static string version = "0.1.3";

        //Regex for validation IPv4 read from user
        private static Regex regex = new Regex("^([0-9]|[1-9][0-9]|[1-9][0-9][0-9])[.]([0-9]|[1-9][0-9]|[1-9][0-9][0-9])[.]([0-9]|[1-9][0-9]|[1-9][0-9][0-9])[.]([0-9]|[1-9][0-9]|[1-9][0-9][0-9])$");

        private static Window window;

        /// <summary>
        /// Load arguments depending on config file
        /// </summary>
        private static void LoadArguments()
        {
            dhcp = "netsh interface ip set address \"" + Config.GetValue("interface") + "\" dhcp";
            staticIp = "netsh interface ip set address name=\"" + Config.GetValue("interface") + "\" static " + Config.GetValue("ip") + " " + Config.GetValue("mask") + " " + Config.GetValue("gateway") + " 1";
        }

        /// <summary>
        /// Runs new command promt as a process.
        /// </summary>
        /// <param name="arg">Text inserted into command prompt</param>
        public static void RunProcess(string arg)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(arg);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            System.Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            cmd.WaitForExit();
        }

        /// <summary>
        /// Load values from TextFields nad save them to config file.
        /// </summary>
        private static void SaveNewConfig()
        {
            string ip = window.IpTextBox.Text;
            string mask = window.MaskTextBox.Text;
            string gateway = window.GatewayTextBox.Text;

            if (regex.IsMatch(ip) && regex.IsMatch(mask) && regex.IsMatch(gateway))
            {
                SetNormalMode();

                Config.SetValue("ip", ip);
                Config.SetValue("mask", mask);
                Config.SetValue("gateway", gateway);
                Config.Save(configPath);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter correct data!", "Validation issue", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// Set edit mode in window. It allows user to change values in Static IP settings.
        /// </summary>
        private static void SetEditMode()
        {
            editMode = true;
            window.EditConfigMenuItem.Enabled = false;
            window.IpTextBox.Enabled = true;
            window.MaskTextBox.Enabled = true;
            window.GatewayTextBox.Enabled = true;
            window.DhcpButton.Visible = false;
            window.StaticButton.Text = "Save config";
        }

        /// <summary>
        /// Set normal mode in window. It allows user to choose between DHCP and Static IP settings.
        /// </summary>
        private static void SetNormalMode()
        {
            editMode = false;
            window.EditConfigMenuItem.Enabled = true;
            window.IpTextBox.Enabled = false;
            window.MaskTextBox.Enabled = false;
            window.GatewayTextBox.Enabled = false;
            window.DhcpButton.Visible = true;
            window.StaticButton.Text = "Static IP";
        }

        /// <summary>
        /// Initialize TextField's in window with values from config file
        /// </summary>
        private static void InitWindowTextFields()
        {
            window.IpTextBox.Text = Config.GetValue("ip");
            window.MaskTextBox.Text = Config.GetValue("mask");
            window.GatewayTextBox.Text = Config.GetValue("gateway");
            window.InterfaceLabel.Text += Config.GetValue("interface");
        }

        /// <summary>
        /// Create and initialize window
        /// </summary>
        private static void InitializeWindow()
        {
            window = new Window();

            window.AboutVersionLabel.Text += version;

            //Add actions to Buttons
            window.EditConfigMenuItem.Click += (o, e) =>
            {
                SetEditMode();
            };

            window.StaticButton.Click += (o, e) =>
            {
                if (editMode)
                {
                    SaveNewConfig();

                    //It is needed when program cannot find config file
                    //Without it new config typed by the user would not be loadeed to command prompt args
                    //TO-DO: Try to find another solution
                    LoadArguments();
                }
                else
                {
                    RunProcess(staticIp);
                } 
            };

            window.DhcpButton.Click += (o, e) =>
            {
                RunProcess(dhcp);
            };

            //Try to initialize TextFields with config file
            try
            {
                Config.Load(configPath);
                InitWindowTextFields();
                LoadArguments();
            }
            catch (System.IO.FileNotFoundException e)
            {
                //When config file not found create new form to take from user network interface name
                System.Windows.Forms.MessageBox.Show("Config file not found!", "File not found!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                InterfaceDialog interfaceDialog = new InterfaceDialog();
                interfaceDialog.ShowDialog();

                Config.SetValue("interface", interfaceDialog.TextBox1.Text);
                window.InterfaceLabel.Text += interfaceDialog.TextBox1.Text;
                SetEditMode();
            }
        }

        /// <summary>
        /// Run entire application
        /// </summary>
        public static void Run()
        {
            InitializeWindow();
            window.ShowDialog();
        }
    }
}
