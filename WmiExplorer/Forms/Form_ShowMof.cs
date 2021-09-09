using System;
using System.Windows.Forms;

namespace WmiExplorer
{
    
    public sealed partial class Form_ShowMof : Form
    {
        private readonly string _mofText;

        public Form_ShowMof(string mofText, string caption = null)
        {
            _mofText = mofText;
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

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(_mofText);
        }
    }
}
