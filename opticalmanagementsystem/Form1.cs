using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opticalmanagementsystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int startp = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startp += 1;
            myprogressBar.Value = startp;
            presentagelbl.Text = startp + "%";
            if (myprogressBar.Value == 100)
            {
                myprogressBar.Value = 0;
                timer1.Stop();
                login obj = new login();
                obj.Show();
                this.Hide();
            }
        }

        private void myprogressBar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void presentagelbl_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
