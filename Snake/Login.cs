using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Snake
{
    public partial class Login : Form
    {
        string path = "C:\\Users\\Envy\\Desktop\\Snake\\Users.txt";
        string name;
        public Login()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape) this.Close();
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            LogInChoice.Visible = true;
            RegisterLabel.Visible = true;
            NameLabel.Visible = true;
            NameUser.Visible = true;
            PassLabel.Visible = true;
            PassUser.Visible = true;
            GenderLabel.Visible = true;
            GenderMan.Visible = true;
            GenderWoman.Visible = true;
            ConfirmButton.Visible = true;
            groupBox1.Visible = true;
            LogInButton.Visible = false;
            SignUpButton.Visible = false;
            ExitButton.Visible = false;
            accountlabel.Visible = false;
            BackButton.Visible = true;
            RegisterLabel.Text = "Register";
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            name = NameUser.Text;
            string password = PassUser.Text;
            char gender = 'M';
            if (GenderMan.Checked) gender = 'M';
            else gender = 'F';
            bool account = false;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] info = line.Split();
                    if (info[0] == name)
                    {
                        account = true;
                        accountlabel.Text = "You have account!";
                        accountlabel.Visible = true;
                    }
                }
            }
            if (account == false)
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine($"{name} {password} {gender} 0 0");
                }
            }
            LogInChoice.Visible = false;
            RegisterLabel.Visible = false;
            NameLabel.Visible = false;
            NameUser.Visible = false;
            PassLabel.Visible = false;
            PassUser.Visible = false;
            GenderLabel.Visible = false;
            GenderMan.Visible = false;
            BackButton.Visible = false;
            GenderWoman.Visible = false;
            ConfirmButton.Visible = false;
            groupBox1.Visible = false;
            LogInButton.Visible = true;
            SignUpButton.Visible = true;
            ExitButton.Visible = true;
            NameUser.Text = "";
            PassUser.Text = "";
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            LogInChoice.Visible = true;
            RegisterLabel.Text = "Authorizing";
            RegisterLabel.Visible = true;
            NameLabel.Visible = true;
            NameUser.Visible = true;
            PassLabel.Visible = true;
            PassUser.Visible = true;
            ConfirmLogIn.Visible = true;
            LogInButton.Visible = false;
            SignUpButton.Visible = false;
            ExitButton.Visible = false;
            accountlabel.Visible = false;
            BackButton.Visible = true;
        }

        private void ConfirmLogIn_Click(object sender, EventArgs e)
        {
            name = NameUser.Text;
            string password = PassUser.Text;
            bool account = false;
            string gender = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] info = line.Split();
                    if (info[0] == name && info[1] == password)
                    {
                        account = true;
                    }
                }
            }
            LogInChoice.Visible = false;
            RegisterLabel.Visible = false;
            NameLabel.Visible = false;
            NameUser.Visible = false;
            PassLabel.Visible = false;
            PassUser.Visible = false;
            ConfirmLogIn.Visible = false;
            LogInButton.Visible = true;
            SignUpButton.Visible = true;
            ExitButton.Visible = true;
            NameUser.Text = "";
            PassUser.Text = "";
            BackButton.Visible = false;
            if (account == true)
            {
                Menu menu = new Menu(name);
                this.Hide();
                menu.ShowDialog();
                this.Show();
            }
            else
            {
                accountlabel.Text = "Incorrect name or password. Try again!";
                accountlabel.Visible = true;
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LogInChoice.Visible = false;
            RegisterLabel.Visible = false;
            NameLabel.Visible = false;
            NameUser.Visible = false;
            PassLabel.Visible = false;
            PassUser.Visible = false;
            GenderLabel.Visible = false;
            GenderMan.Visible = false;
            GenderWoman.Visible = false;
            ConfirmButton.Visible = false;
            groupBox1.Visible = false;
            ConfirmLogIn.Visible = false;
            LogInButton.Visible = true;
            SignUpButton.Visible = true;
            ExitButton.Visible = true;
            NameUser.Text = "";
            PassUser.Text = "";
            BackButton.Visible = false;
        }
    }
}
