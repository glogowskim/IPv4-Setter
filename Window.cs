using System;
using System.Windows.Forms;

namespace IPv4Setter
{

    public partial class Window : Form
    {
        private About aboutDialog;
        
        public Window()
        {
            InitializeComponent();
            this.CenterToScreen();
            aboutDialog = new About();

            Application.EnableVisualStyles();
        }

        public void dhcpButton_Click(object sender, EventArgs e)
        {

        }

        public void staticButton_Click(object sender, EventArgs e)
        {

        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            aboutDialog.Visible = true;
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void editConfigMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public TextBox IpTextBox { get => ipTextBox; set => ipTextBox = value; }
        public TextBox MaskTextBox {  get => maskTextBox; set => maskTextBox = value; }
        public TextBox GatewayTextBox { get => gatewayTextBox; set => gatewayTextBox = value; }
        public ToolStripMenuItem EditConfigMenuItem { get => editConfigMenuItem; set => editConfigMenuItem = value; }
        public Button DhcpButton { get => dhcpButton;  set => dhcpButton = value; }
        public Button StaticButton { get => staticButton;  set => staticButton = value; }

        public Label AboutVersionLabel { get => aboutDialog.VersionLabel; set => aboutDialog.VersionLabel = value; }
        public Label InterfaceLabel { get => interfaceLabel; set => InterfaceLabel = value; }

    }
}
