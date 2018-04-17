using System;
using System.Windows.Forms;

namespace IPv4Setter
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public Label VersionLabel { get => versionLabel; set => versionLabel = value; }
    }
}
