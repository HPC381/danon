using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Main : Form
    {
        private cpu form2;
        private gpu form3;
        private mother form4;
        private order form5;
        public Main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2 = new cpu();
            form2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form5 = new order();
            form5.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form4 = new mother();
            form4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form3 = new gpu();
            form3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
