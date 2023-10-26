using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Snake
{
    public partial class Snake : Form
    {
        Color[] colors =
        {
            Color.Blue, Color.Magenta, Color.Black, Color.Lime, Color.Aqua
        };
        string path = "C:\\Users\\Envy\\Desktop\\Snake\\Users.txt";
        string newPath = "C:\\Users\\Envy\\Desktop\\Snake\\Users1.txt";
        private static int mapSize = 15;
        private int size = 40;
        string name;
        private int rX, rY;

        private PictureBox fruit;
        private PictureBox[] snake = new PictureBox[mapSize * mapSize];
        Color colorSnake = Color.Blue;

        private int X, Y;

        private int score = 0;
        private int bestScore = 0;

        bool finish = false;
        public Snake(string name)
        {
            InitializeComponent();
            X = 1;
            Y = 0;
            snake[0] = new PictureBox();
            snake[0].Location = new Point(0, 0);
            snake[0].Size = new Size(size, size);
            snake[0].BackColor = Color.Red;
            this.Controls.Add(snake[0]);
            fruit = new PictureBox();
            fruit.BackColor = Color.Yellow;
            fruit.Size = new Size(size, size);
            generateFruit();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] info = line.Split();
                    if (info[0] == name)
                    {
                        colorSnake = colors[int.Parse(info[4])];
                    }
                }
            }
            this.name = name;
        }

        private void generateFruit()
        {
            if (!finish)
            {
                Random random = new Random();
                do
                {
                    rX = random.Next(mapSize) * size;
                    rY = random.Next(mapSize) * size;
                } while (!CheckCollision(rX, rY));

                fruit.Location = new Point(rX, rY);
                this.Controls.Add(fruit);
            }
        }

        private bool CheckCollision(int x, int y)
        {
            foreach (PictureBox snakePart in snake)
            {
                if (snakePart != null && snakePart.Location.X == x && snakePart.Location.Y == y)
                {
                    return false;   
                }
            }
            return true;
        }

        private void eatFruit()
        {
            if (snake[0].Location.X == rX && snake[0].Location.Y == rY)
            {
                score++;
                snake[score] = new PictureBox();
                snake[score].Location = new Point(snake[score - 1].Location.X + size * X, snake[score - 1].Location.Y - size * Y);
                snake[score].Size = new Size(size, size);
                snake[score].BackColor = colorSnake;
                this.Controls.Add(snake[score]);
                generateFruit();
            }
        }

        private void checkBorders()
        {
            if (snake[0].Location.X < 0)
            {
                snake[0].Location = new Point(size * (mapSize - 1), snake[0].Location.Y);
            }
            else if (snake[0].Location.X >= size * mapSize)
            {
                snake[0].Location = new Point(0, snake[0].Location.Y);
            }
            else if (snake[0].Location.Y < 0)
            {
                snake[0].Location = new Point(snake[0].Location.X, size * (mapSize - 1));
            }
            else if (snake[0].Location.Y > size * (mapSize - 1))
            {
                snake[0].Location = new Point(snake[0].Location.X, 0);
            }
        }

        private void eatItself()
        {
            for (int i = 1; i < score; i++)
            {
                if (snake[0].Location == snake[i].Location)
                {
                    timer.Enabled = false;
                    GameOverPicture.Visible = true;
                    RestartButton.Visible = true;
                    if (score > bestScore) bestScore = score;
                    File.Create(newPath).Close();
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
                                    fileWriter.WriteLine($"{info[0]} {info[1]} {info[2]} {bestScore} {info[4]}");
                                }
                                else fileWriter.WriteLine(line);
                            }
                        }
                    }
                    File.Delete(path);
                    File.Move(newPath, path);
                    ScoreBackPicture.Visible = true;
                    ScoreLabel.Left = BestScoreLabel.Left;
                    ScoreLabel.Top = BestScoreLabel.Top - 50;
                    BestScoreLabel.Text = "Best: " + bestScore;
                    BestScoreLabel.Visible = true;
                    ScoreLabel.BackColor = Color.MediumTurquoise;
                }
            }
        }

        private void moveSnake()
        {
            for (int i = score; i >= 1; i--)
            {
                snake[i].Location = snake[i - 1].Location;
            }
            snake[0].Location = new Point(snake[0].Location.X + X * size, snake[0].Location.Y + Y * size);
            eatItself();
        }

        private void generateMap(Graphics g)
        {
            for (int i = 0; i <= mapSize; i++)
            {
                g.DrawLine(Pens.Gray, new Point(0, i * size), new Point(size * mapSize, i * size));
                g.DrawLine(Pens.Gray, new Point(size * i, 0), new Point(size * i, size * mapSize));
            }
        }

        private void Snake_Paint(object sender, PaintEventArgs e)
        {
            generateMap(e.Graphics);
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            X = 1;
            Y = 0;
            for (int i = 1; i <= score; i++) this.Controls.Remove(snake[i]);
            score = 0;
            snake[0].Location = new Point(0, 0);
            this.Controls.Add(snake[0]);
            generateFruit();
            timer.Enabled = true;
            GameOverPicture.Visible = false;
            RestartButton.Visible = false;
            ScoreBackPicture.Visible = false;
            BestScoreLabel.Visible = false;
            ScoreLabel.Left = RestartButton.Left + 75;
            ScoreLabel.Top = RestartButton.Top;
            ScoreLabel.BackColor = Color.Transparent;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ScoreLabel.Text = "" + score;
            if (score == snake.Length - 2)
            {
                timer.Enabled = false;
                WinPicture.Visible = true;
                RestartButton.Visible = true;
                if (score > bestScore) bestScore = score;
                File.Create(newPath).Close();
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
                                fileWriter.WriteLine($"{info[0]} {info[1]} {info[2]} {bestScore} {info[4]}");
                            }
                            else fileWriter.WriteLine(line);
                        }
                    }
                }
                File.Delete(path);
                File.Move(newPath, path);
                ScoreBackPicture.Visible = true;
                ScoreLabel.Left = BestScoreLabel.Left;
                ScoreLabel.Top = BestScoreLabel.Top - 50;
                BestScoreLabel.Text = "Best: " + bestScore;
                BestScoreLabel.Visible = true;
                ScoreLabel.BackColor = Color.MediumTurquoise;
            }
            checkBorders();
            eatFruit();
            moveSnake();
        }
        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            if (key == Keys.Escape) this.Close();
            else if (key == Keys.Left || key == Keys.A)
            {
                if (X != 1 && Y != 0)
                {
                    X = -1;
                    Y = 0;
                }
            }
            else if (key == Keys.Right || key == Keys.D)
            {
                if (X != -1 && Y != 0)
                {
                    X = 1;
                    Y = 0;
                }
            }
            else if (key == Keys.Up || key == Keys.W)
            {
                if (X != 0 && Y != 1)
                {
                    X = 0;
                    Y = -1;
                }
            }
            else if (key == Keys.Down || key == Keys.S)
            {
                if (X != 0 && Y != -1)
                {
                    X = 0;
                    Y = 1;
                }
            }
        }
    }
}
