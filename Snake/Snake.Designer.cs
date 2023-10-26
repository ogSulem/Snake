namespace Snake
{
    partial class Snake
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snake));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.GameOverPicture = new System.Windows.Forms.PictureBox();
            this.RestartButton = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.BestScoreLabel = new System.Windows.Forms.Label();
            this.ScoreBackPicture = new System.Windows.Forms.PictureBox();
            this.WinPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBackPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // GameOverPicture
            // 
            this.GameOverPicture.Image = ((System.Drawing.Image)(resources.GetObject("GameOverPicture.Image")));
            this.GameOverPicture.Location = new System.Drawing.Point(131, 81);
            this.GameOverPicture.Margin = new System.Windows.Forms.Padding(2);
            this.GameOverPicture.Name = "GameOverPicture";
            this.GameOverPicture.Size = new System.Drawing.Size(338, 244);
            this.GameOverPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameOverPicture.TabIndex = 0;
            this.GameOverPicture.TabStop = false;
            this.GameOverPicture.Visible = false;
            // 
            // RestartButton
            // 
            this.RestartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RestartButton.BackgroundImage")));
            this.RestartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RestartButton.Location = new System.Drawing.Point(206, 658);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(188, 41);
            this.RestartButton.TabIndex = 1;
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Visible = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.Black;
            this.ScoreLabel.Location = new System.Drawing.Point(281, 658);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(45, 51);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "0";
            // 
            // BestScoreLabel
            // 
            this.BestScoreLabel.AutoSize = true;
            this.BestScoreLabel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BestScoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BestScoreLabel.ForeColor = System.Drawing.Color.Black;
            this.BestScoreLabel.Location = new System.Drawing.Point(150, 406);
            this.BestScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BestScoreLabel.Name = "BestScoreLabel";
            this.BestScoreLabel.Size = new System.Drawing.Size(156, 51);
            this.BestScoreLabel.TabIndex = 3;
            this.BestScoreLabel.Text = "Best: 0";
            this.BestScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BestScoreLabel.Visible = false;
            // 
            // ScoreBackPicture
            // 
            this.ScoreBackPicture.Image = ((System.Drawing.Image)(resources.GetObject("ScoreBackPicture.Image")));
            this.ScoreBackPicture.Location = new System.Drawing.Point(131, 345);
            this.ScoreBackPicture.Margin = new System.Windows.Forms.Padding(2);
            this.ScoreBackPicture.Name = "ScoreBackPicture";
            this.ScoreBackPicture.Size = new System.Drawing.Size(338, 122);
            this.ScoreBackPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ScoreBackPicture.TabIndex = 4;
            this.ScoreBackPicture.TabStop = false;
            this.ScoreBackPicture.Visible = false;
            // 
            // WinPicture
            // 
            this.WinPicture.Image = ((System.Drawing.Image)(resources.GetObject("WinPicture.Image")));
            this.WinPicture.Location = new System.Drawing.Point(131, 81);
            this.WinPicture.Margin = new System.Windows.Forms.Padding(2);
            this.WinPicture.Name = "WinPicture";
            this.WinPicture.Size = new System.Drawing.Size(338, 244);
            this.WinPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WinPicture.TabIndex = 11;
            this.WinPicture.TabStop = false;
            this.WinPicture.Visible = false;
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 731);
            this.Controls.Add(this.BestScoreLabel);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.ScoreBackPicture);
            this.Controls.Add(this.GameOverPicture);
            this.Controls.Add(this.WinPicture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Snake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Snake_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snake_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GameOverPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBackPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox GameOverPicture;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label BestScoreLabel;
        private System.Windows.Forms.PictureBox ScoreBackPicture;
        private System.Windows.Forms.PictureBox WinPicture;
    }
}