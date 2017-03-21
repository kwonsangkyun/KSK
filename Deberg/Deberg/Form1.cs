using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deberg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked != true)
                MessageBox.Show("The box is not checked");
            else
            { if (label1.BackColor == Color.Red)
                    label1.BackColor = Color.Blue;
                else if (label1.BackColor == Color.Blue)
                    label1.BackColor = Color.Red;

             }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
