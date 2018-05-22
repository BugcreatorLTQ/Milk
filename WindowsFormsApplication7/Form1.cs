using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class 奶牛 : Form
    {
        public 奶牛()
        {
            InitializeComponent();
        }

        private void toolboxControl1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string x1 = textX1.Text;
            string x2 = textX2.Text;
            string x3 = textX3.Text;
            string x4 = textX4.Text;
            string x5 = textX5.Text;
            string x6 = textX6.Text;
            string x7 = textX7.Text;
            double[,] w1 = new double[,] { {0.9880,-0.2664,-0.9157,0.0206,-0.5388,-0.7711,2.4399},
                                           {3.0299,2.1328,-1.6592,-0.5420,-0.1957,1.4950,-0.2351} };
        }
    }
}
