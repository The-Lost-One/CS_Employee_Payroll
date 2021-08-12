using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Employee_Payroll
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InitializeMyControl();
        }

        private void InitializeMyControl()
        {
            // Set to no text.
            txtPassword.Text = "";
            // The password character is an asterisk.
            txtPassword.PasswordChar = '*';
            // The control will allow no more than 8 characters.
            txtPassword.MaxLength = 8;
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtPassword.Text == "admin")
            {
                new Form1().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("The User name or password you entered is incorrect, try again");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }
    }
}
