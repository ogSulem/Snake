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

namespace Snake
{
    public partial class Menu : Form
    {
        string newPath = "C:\\Users\\Envy\\Desktop\\Snake\\temp.txt";
        string name;
        char gender;
        string path = "C:\\Users\\Envy\\Desktop\\Snake\\Users.txt";
        string[] colors =
        {
            "C:\\Users\\Envy\\Desktop\\spites\\color1.png",
            "C:\\Users\\Envy\\Desktop\\spites\\color2.png",
            "C:\\Users\\Envy\\Desktop\\spites\\color3.png",
            "C:\\Users\\Envy\\Desktop\\spites\\color4.png",
            "C:\\Users\\Envy\\Desktop\\spites\\color5.png"
        };
        public Menu(string name)
        {
            InitializeComponent();
            this.name = name;
            NameUser.Text = name;
            int color = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] info = line.Split();
                    if (info[0] == name)
                    {
                        gender = char.Parse(info[2]);
                        if (gender == 'M') GenderUser.Text = "Man";
                        else GenderUser.Text = "Woman";
                        ScoreUser.Text = info[3];
                        color = int.Parse(info[4]);
                        colorpic.ImageLocation = colors[color];
                        PassInput.Text = info[1];
                    }
                }
            }
            comboBox1.Items.Add("Blue");
            comboBox1.Items.Add("Pink");
            comboBox1.Items.Add("Black");
            comboBox1.Items.Add("Green");
            comboBox1.Items.Add("Aqua");
            comboBox1.SelectedIndex = color;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Snake game = new Snake(NameUser.Text);
            this.Hide();
            game.ShowDialog();
            this.Show();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] info = line.Split();
                    if (info[0] == name)
                    {
                        ScoreUser.Text = info[3];
                    }
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape) this.Close();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            NameUser.Visible = false;
            GenderUser.Visible = false;
            ScoreUser.Visible = false;
            SettingsButton.Visible = false;
            SaveButton.Visible = true;
            NameInput.Text = NameUser.Text;
            NameInput.Visible = true;
            GenderMan.Visible = true;
            GenderWoman.Visible = true;
            groupBox1.Visible = true;
            comboBox1.Visible = true;

            if (GenderUser.Text == "Man") GenderMan.Checked = true;
            else GenderWoman.Checked = true;
            ScoreLabel.Text = "Password:";
            PassInput.Visible = true;
            PlayButton.Visible = false;
            ExitButton.Visible = false;
            ErrorLabel.Visible = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            NameUser.Visible = true;
            GenderUser.Visible = true;
            ScoreUser.Visible = true;
            SettingsButton.Visible = true;
            PlayButton.Visible = true;
            ExitButton.Visible = true;
            SaveButton.Visible = false;
            if (GenderMan.Checked)
            {
                GenderUser.Text = "Man";
                gender = 'M';
            }
            else
            {
                GenderUser.Text = "Woman";
                gender = 'F';
            }
            NameInput.Visible = false;
            GenderMan.Visible = false;
            GenderWoman.Visible = false;
            groupBox1.Visible = false;
            comboBox1.Visible = false;
            ScoreLabel.Text = "BestScore:";
            PassInput.Visible = false;
            File.Create(newPath).Close();
            bool nameHave = false;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] info = line.Split();
                    if (info[0] == NameInput.Text)
                    {
                        nameHave = true;
                    }
                }
            }
            if (!nameHave) {
                using (StreamWriter fileWriter = new StreamWriter(newPath))
                {
                    using (StreamReader fileReader = new StreamReader(path))
                    {
                        string line;
                        while ((line = fileReader.ReadLine()) != null)
                        {
                            string[] info = line.Split();
                            if (info[0] == name)
                            {
                                NameUser.Text = NameInput.Text;
                                fileWriter.WriteLine($"{NameUser.Text} {PassInput.Text} {gender} {info[3]} {comboBox1.SelectedIndex}");
                            }
                            else fileWriter.WriteLine(line);
                        }
                    }
                } 
            }
            else
            {
                using (StreamWriter fileWriter = new StreamWriter(newPath))
                {
                    using (StreamReader fileReader = new StreamReader(path))
                    {
                        string line;
                        while ((line = fileReader.ReadLine()) != null)
                        {
                            string[] info = line.Split();
                            if (info[0] == name)
                            {
                                fileWriter.WriteLine($"{NameUser.Text} {PassInput.Text} {gender} {info[3]} {comboBox1.SelectedIndex}");
                                if (info[0] != NameInput.Text)
                                    ErrorLabel.Visible = true;
                            }
                            else fileWriter.WriteLine(line);
                        }
                    }
                }
            }

            File.Delete(path);
            File.Move(newPath, path);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int color = comboBox1.SelectedIndex;
            colorpic.ImageLocation = colors[color];
        }
    }
}
