﻿using System;
using System.Windows.Forms;

namespace PersonalLoanOffer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var loggedIn = true;
            if (loggedIn)
            {
                this.Hide();
                new MainForm().Show();
            }
        }
    }
}
