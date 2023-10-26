namespace Snake
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.PlayButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.colorpic = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.NameUser = new System.Windows.Forms.Label();
            this.GenderUser = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ScoreUser = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GenderMan = new System.Windows.Forms.RadioButton();
            this.GenderWoman = new System.Windows.Forms.RadioButton();
            this.SaveButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PassInput = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.colorpic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayButton.BackgroundImage")));
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayButton.Location = new System.Drawing.Point(206, 600);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(188, 41);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.Location = new System.Drawing.Point(206, 666);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(188, 41);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // colorpic
            // 
            this.colorpic.Image = ((System.Drawing.Image)(resources.GetObject("colorpic.Image")));
            this.colorpic.Location = new System.Drawing.Point(100, 200);
            this.colorpic.Margin = new System.Windows.Forms.Padding(2);
            this.colorpic.Name = "colorpic";
            this.colorpic.Size = new System.Drawing.Size(113, 203);
            this.colorpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorpic.TabIndex = 7;
            this.colorpic.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Black;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.NameLabel.Location = new System.Drawing.Point(225, 225);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(79, 25);
            this.NameLabel.TabIndex = 11;
            this.NameLabel.Text = "Name:";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.BackColor = System.Drawing.Color.Black;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenderLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.GenderLabel.Location = new System.Drawing.Point(225, 275);
            this.GenderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(96, 25);
            this.GenderLabel.TabIndex = 12;
            this.GenderLabel.Text = "Gender:";
            // 
            // NameUser
            // 
            this.NameUser.AutoSize = true;
            this.NameUser.BackColor = System.Drawing.Color.Black;
            this.NameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameUser.ForeColor = System.Drawing.SystemColors.Control;
            this.NameUser.Location = new System.Drawing.Point(325, 225);
            this.NameUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameUser.Name = "NameUser";
            this.NameUser.Size = new System.Drawing.Size(72, 25);
            this.NameUser.TabIndex = 13;
            this.NameUser.Text = "Name";
            // 
            // GenderUser
            // 
            this.GenderUser.AutoSize = true;
            this.GenderUser.BackColor = System.Drawing.Color.Black;
            this.GenderUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenderUser.ForeColor = System.Drawing.SystemColors.Control;
            this.GenderUser.Location = new System.Drawing.Point(340, 275);
            this.GenderUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenderUser.Name = "GenderUser";
            this.GenderUser.Size = new System.Drawing.Size(57, 25);
            this.GenderUser.TabIndex = 14;
            this.GenderUser.Text = "Man";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Black;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ScoreLabel.Location = new System.Drawing.Point(225, 325);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(127, 25);
            this.ScoreLabel.TabIndex = 15;
            this.ScoreLabel.Text = "BestScore:";
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(230, 367);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(167, 36);
            this.SettingsButton.TabIndex = 16;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ScoreUser
            // 
            this.ScoreUser.AutoSize = true;
            this.ScoreUser.BackColor = System.Drawing.Color.Black;
            this.ScoreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreUser.ForeColor = System.Drawing.SystemColors.Control;
            this.ScoreUser.Location = new System.Drawing.Point(365, 325);
            this.ScoreUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScoreUser.Name = "ScoreUser";
            this.ScoreUser.Size = new System.Drawing.Size(25, 25);
            this.ScoreUser.TabIndex = 17;
            this.ScoreUser.Text = "0";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(330, 231);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 20);
            this.NameInput.TabIndex = 18;
            this.NameInput.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GenderMan);
            this.groupBox1.Controls.Add(this.GenderWoman);
            this.groupBox1.Location = new System.Drawing.Point(345, 285);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(142, 15);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // GenderMan
            // 
            this.GenderMan.AutoSize = true;
            this.GenderMan.Location = new System.Drawing.Point(2, 0);
            this.GenderMan.Margin = new System.Windows.Forms.Padding(2);
            this.GenderMan.Name = "GenderMan";
            this.GenderMan.Size = new System.Drawing.Size(46, 17);
            this.GenderMan.TabIndex = 11;
            this.GenderMan.TabStop = true;
            this.GenderMan.Text = "Man";
            this.GenderMan.UseVisualStyleBackColor = true;
            this.GenderMan.Visible = false;
            // 
            // GenderWoman
            // 
            this.GenderWoman.AutoSize = true;
            this.GenderWoman.Location = new System.Drawing.Point(76, 0);
            this.GenderWoman.Margin = new System.Windows.Forms.Padding(2);
            this.GenderWoman.Name = "GenderWoman";
            this.GenderWoman.Size = new System.Drawing.Size(62, 17);
            this.GenderWoman.TabIndex = 12;
            this.GenderWoman.TabStop = true;
            this.GenderWoman.Text = "Woman";
            this.GenderWoman.UseVisualStyleBackColor = true;
            this.GenderWoman.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(230, 367);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(167, 36);
            this.SaveButton.TabIndex = 20;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 408);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PassInput
            // 
            this.PassInput.Location = new System.Drawing.Point(370, 330);
            this.PassInput.Name = "PassInput";
            this.PassInput.PasswordChar = '*';
            this.PassInput.Size = new System.Drawing.Size(100, 20);
            this.PassInput.TabIndex = 22;
            this.PassInput.Visible = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.Location = new System.Drawing.Point(236, 406);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(161, 19);
            this.ErrorLabel.TabIndex = 23;
            this.ErrorLabel.Text = "Nickname is busy!";
            this.ErrorLabel.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 731);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.PassInput);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.ScoreUser);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.GenderUser);
            this.Controls.Add(this.NameUser);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.colorpic);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PlayButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Menu_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.colorpic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox colorpic;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label NameUser;
        private System.Windows.Forms.Label GenderUser;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Label ScoreUser;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton GenderMan;
        private System.Windows.Forms.RadioButton GenderWoman;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox PassInput;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

