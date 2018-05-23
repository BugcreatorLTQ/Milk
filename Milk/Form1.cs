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
    public partial class Milk : Form
    {
        public Milk()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.TxtInput1.Text = "";
            this.TxtInput2.Text = "";
            this.TxtInput3.Text = "";
            this.TxtInput4.Text = "";
            this.TxtInput5.Text = "";
            this.TxtInput6.Text = "";
            this.TxtInput7.Text = "";
            this.TxtOutput1.Text = "";
            this.TxtOutput2.Text = "";
            this.TxtOutput3.Text = "";
        }

        private void Run_Click(object sender, EventArgs e)
        {

        }
    }
}
