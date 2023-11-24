using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEP_ERG3
{
    public partial class RichTextbox : Form
    {
        public RichTextbox()
        {
            InitializeComponent();
            
           Program.richtextbox=richTextBox1;
            Program.richtextbox.Text = Program.output;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
