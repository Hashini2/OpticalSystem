﻿using System;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (unametb.Text == "" && passwordtb.Text == "")
            {
                MessageBox.Show("Enter user name and password");
            }
            else
            {
                
                if (unametb.Text == "janasewa" && passwordtb.Text == "Admin" )
                {
                    
                    home obj = new home();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("wrong username or password");
                }
               
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
