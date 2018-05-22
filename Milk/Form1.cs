using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Milk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int year = int.Parse(this.textBox1.Text);
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                // Console.WriteLine(year + "是闰年");
                MessageBox.Show(year + "是闰年");
            }
            else
            {
                MessageBox.Show(year + "不是闰年");
            }
        }
    }
}
