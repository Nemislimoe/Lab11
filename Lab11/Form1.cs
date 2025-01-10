using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            string confirmPassword = ConfirmPasswordTextBox.Text;
            string email = EmailTextBox.Text;
            bool isTermsAccepted = agreementCheckBox.Checked;

            if (password != confirmPassword)
            {
                ErrorMessageLabel.Text = "Password does not match";
                ErrorMessageLabel.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) 
                || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(email))
            {
                ErrorMessageLabel.Text = "All lines must be filled in";
                ErrorMessageLabel.ForeColor = Color.Red;
                return;
            }

            if (!isTermsAccepted)
            {
                ErrorMessageLabel.Text = "All terms must be accepted";
                ErrorMessageLabel.ForeColor = Color.Red;
                return;
            }

            ErrorMessageLabel.Text = "Registr succesful";
            ErrorMessageLabel.ForeColor = Color.Green;

            LoginTextBox.Clear();
            PasswordTextBox.Clear();
            ConfirmPasswordTextBox.Clear();
            EmailTextBox.Clear();

            agreementCheckBox.Checked = false;

            System.Diagnostics.Process.Start("https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/f6a9e9a9-d9fb-42a1-b597-1d4faa244642/diuobq3-a7729229-536f-4855-a834-acc89139cdca.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcL2Y2YTllOWE5LWQ5ZmItNDJhMS1iNTk3LTFkNGZhYTI0NDY0MlwvZGl1b2JxMy1hNzcyOTIyOS01MzZmLTQ4NTUtYTgzNC1hY2M4OTEzOWNkY2EucG5nIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.XinP2IfpR5zEhRWJA9S526cHakH04LF14hI0YE9Rxv0");

        }

        private void agreementCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
