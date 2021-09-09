using System;
using System.Windows.Forms;

namespace WmiExplorer
{
    
    public sealed partial class Form_ShowMof : Form
    {
        public Form_ShowMof(string mofText, string caption = null)
        {
            InitializeComponent();
            textBoxShowMOF.Text = "\r\n" + mofText;
            if (!string.IsNullOrWhiteSpace(caption))
            {
                Text = caption;
            }
        }

        private void buttonCloseMOF_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
