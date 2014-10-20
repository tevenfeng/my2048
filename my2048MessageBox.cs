using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my2048
{
    public partial class my2048MessageBox : Form
    {
        public my2048MessageBox()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = false;
            this.Hide();
            base.OnClosing(e);
        }

        public string messageA { get; set; }
        public string messageB { get; set; }

        private void my2048MessageBox_Load(object sender, EventArgs e)
        {
            label_messageA.Text = messageA;
            textBox_messageInformation.Text = messageB;
            this.TopLevel = true;
        }

        private void my204MessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }
    }
}
