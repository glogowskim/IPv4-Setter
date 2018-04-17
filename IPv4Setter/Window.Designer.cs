using System.Windows.Forms;

namespace IPv4Setter
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.dhcpButton = new System.Windows.Forms.Button();
            this.staticButton = new System.Windows.Forms.Button();
            this.staticIpLabel = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.maskTextBox = new System.Windows.Forms.TextBox();
            this.gatewayTextBox = new System.Windows.Forms.TextBox();
            this.interfaceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editConfigMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dhcpButton
            // 
            this.dhcpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dhcpButton.Location = new System.Drawing.Point(22, 112);
            this.dhcpButton.Name = "dhcpButton";
            this.dhcpButton.Size = new System.Drawing.Size(75, 23);
            this.dhcpButton.TabIndex = 0;
            this.dhcpButton.Text = "DHCP";
            this.dhcpButton.UseVisualStyleBackColor = true;
            this.dhcpButton.Click += new System.EventHandler(this.dhcpButton_Click);
            // 
            // staticButton
            // 
            this.staticButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staticButton.Location = new System.Drawing.Point(141, 112);
            this.staticButton.Name = "staticButton";
            this.staticButton.Size = new System.Drawing.Size(75, 23);
            this.staticButton.TabIndex = 0;
            this.staticButton.Text = "Static IP";
            this.staticButton.UseVisualStyleBackColor = true;
            this.staticButton.Click += new System.EventHandler(this.staticButton_Click);
            // 
            // staticIpLabel
            // 
            this.staticIpLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staticIpLabel.AutoSize = true;
            this.staticIpLabel.Location = new System.Drawing.Point(135, 9);
            this.staticIpLabel.Name = "staticIpLabel";
            this.staticIpLabel.Size = new System.Drawing.Size(86, 13);
            this.staticIpLabel.TabIndex = 1;
            this.staticIpLabel.Text = "Static IP settings";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ipTextBox.Enabled = false;
            this.ipTextBox.Location = new System.Drawing.Point(133, 35);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(91, 20);
            this.ipTextBox.TabIndex = 2;
            // 
            // maskTextBox
            // 
            this.maskTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskTextBox.Enabled = false;
            this.maskTextBox.Location = new System.Drawing.Point(133, 58);
            this.maskTextBox.Name = "maskTextBox";
            this.maskTextBox.Size = new System.Drawing.Size(91, 20);
            this.maskTextBox.TabIndex = 2;
            // 
            // gatewayTextBox
            // 
            this.gatewayTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gatewayTextBox.Enabled = false;
            this.gatewayTextBox.Location = new System.Drawing.Point(133, 81);
            this.gatewayTextBox.Name = "gatewayTextBox";
            this.gatewayTextBox.Size = new System.Drawing.Size(91, 20);
            this.gatewayTextBox.TabIndex = 2;
            // 
            // interfaceLabel
            // 
            this.interfaceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.interfaceLabel.AutoSize = true;
            this.interfaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.interfaceLabel.Location = new System.Drawing.Point(26, 9);
            this.interfaceLabel.Name = "interfaceLabel";
            this.interfaceLabel.Size = new System.Drawing.Size(66, 13);
            this.interfaceLabel.TabIndex = 3;
            this.interfaceLabel.Text = "Interface: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mask:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gateway:";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editConfigMenuItem,
            this.ExitMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // editConfigMenuItem
            // 
            this.editConfigMenuItem.Name = "editConfigMenuItem";
            this.editConfigMenuItem.Size = new System.Drawing.Size(131, 22);
            this.editConfigMenuItem.Text = "Edit config";
            this.editConfigMenuItem.Click += new System.EventHandler(this.editConfigMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(44, 20);
            this.HelpMenu.Text = "Help";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AboutMenuItem.Text = "About";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(238, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ipTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.maskTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gatewayTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.staticIpLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.interfaceLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dhcpButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.staticButton, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.0136F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.86274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.86274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.86274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.39819F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(238, 146);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 170);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPv4 Setter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dhcpButton;
        private System.Windows.Forms.Button staticButton;
        private System.Windows.Forms.Label staticIpLabel;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.TextBox maskTextBox;
        private System.Windows.Forms.TextBox gatewayTextBox;
        private System.Windows.Forms.Label interfaceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ToolStripMenuItem FileMenu;
        private ToolStripMenuItem editConfigMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem HelpMenu;
        private ToolStripMenuItem AboutMenuItem;
        private MenuStrip menuStrip1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}