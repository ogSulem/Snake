namespace Snake
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LogInButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogInChoice = new System.Windows.Forms.PictureBox();
            this.NameUser = new System.Windows.Forms.TextBox();
            this.PassUser = new System.Windows.Forms.TextBox();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.GenderMan = new System.Windows.Forms.RadioButton();
            this.GenderWoman = new System.Windows.Forms.RadioButton();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.accountlabel = new System.Windows.Forms.Label();
            this.ConfirmLogIn = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogInChoice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogInButton
            // 
            this.LogInButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogInButton.BackgroundImage")));
            this.LogInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogInButton.Location = new System.Drawing.Point(94, 609);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(188, 41);
            this.LogInButton.TabIndex = 1;
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignUpButton.BackgroundImage")));
            this.SignUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SignUpButton.Location = new System.Drawing.Point(319, 609);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(188, 41);
            this.SignUpButton.TabIndex = 2;
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.Location = new System.Drawing.Point(206, 658);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(188, 41);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LogInChoice
            // 
            this.LogInChoice.Image = ((System.Drawing.Image)(resources.GetObject("LogInChoice.Image")));
            this.LogInChoice.Location = new System.Drawing.Point(0, 0);
            this.LogInChoice.Margin = new System.Windows.Forms.Padding(2);
            this.LogInChoice.Name = "LogInChoice";
            this.LogInChoice.Size = new System.Drawing.Size(600, 731);
            this.LogInChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogInChoice.TabIndex = 4;
            this.LogInChoice.TabStop = false;
            this.LogInChoice.Visible = false;
            // 
            // NameUser
            // 
            this.NameUser.AutoCompleteCustomSource.AddRange(new string[] {
            "name"});
            this.NameUser.Location = new System.Drawing.Point(244, 244);
            this.NameUser.Margin = new System.Windows.Forms.Padding(2);
            this.NameUser.Name = "NameUser";
            this.NameUser.Size = new System.Drawing.Size(188, 20);
            this.NameUser.TabIndex = 5;
            this.NameUser.Visible = false;
            // 
            // PassUser
            // 
            this.PassUser.AutoCompleteCustomSource.AddRange(new string[] {
            "password"});
            this.PassUser.Location = new System.Drawing.Point(244, 284);
            this.PassUser.Margin = new System.Windows.Forms.Padding(2);
            this.PassUser.Name = "PassUser";
            this.PassUser.PasswordChar = '*';
            this.PassUser.Size = new System.Drawing.Size(188, 20);
            this.PassUser.TabIndex = 6;
            this.PassUser.Visible = false;
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("PT Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterLabel.Location = new System.Drawing.Point(221, 158);
            this.RegisterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(216, 62);
            this.RegisterLabel.TabIndex = 7;
            this.RegisterLabel.Text = "Register";
            this.RegisterLabel.Visible = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Black;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.NameLabel.Location = new System.Drawing.Point(138, 244);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(79, 25);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name:";
            this.NameLabel.Visible = false;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.BackColor = System.Drawing.Color.Black;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PassLabel.Location = new System.Drawing.Point(106, 284);
            this.PassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(121, 25);
            this.PassLabel.TabIndex = 9;
            this.PassLabel.Text = "Password:";
            this.PassLabel.Visible = false;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.BackColor = System.Drawing.Color.Black;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenderLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.GenderLabel.Location = new System.Drawing.Point(125, 325);
            this.GenderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(96, 25);
            this.GenderLabel.TabIndex = 10;
            this.GenderLabel.Text = "Gender:";
            this.GenderLabel.Visible = false;
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
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConfirmButton.Location = new System.Drawing.Point(230, 365);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(136, 38);
            this.ConfirmButton.TabIndex = 13;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Visible = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GenderMan);
            this.groupBox1.Controls.Add(this.GenderWoman);
            this.groupBox1.Location = new System.Drawing.Point(244, 325);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(142, 15);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // accountlabel
            // 
            this.accountlabel.AutoSize = true;
            this.accountlabel.BackColor = System.Drawing.Color.Transparent;
            this.accountlabel.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountlabel.Location = new System.Drawing.Point(226, 553);
            this.accountlabel.Name = "accountlabel";
            this.accountlabel.Size = new System.Drawing.Size(151, 20);
            this.accountlabel.TabIndex = 15;
            this.accountlabel.Text = "You have account!";
            this.accountlabel.Visible = false;
            // 
            // ConfirmLogIn
            // 
            this.ConfirmLogIn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConfirmLogIn.Location = new System.Drawing.Point(275, 315);
            this.ConfirmLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmLogIn.Name = "ConfirmLogIn";
            this.ConfirmLogIn.Size = new System.Drawing.Size(136, 38);
            this.ConfirmLogIn.TabIndex = 16;
            this.ConfirmLogIn.Text = "Confirm";
            this.ConfirmLogIn.UseVisualStyleBackColor = false;
            this.ConfirmLogIn.Visible = false;
            this.ConfirmLogIn.Click += new System.EventHandler(this.ConfirmLogIn_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackButton.Location = new System.Drawing.Point(11, 11);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(136, 38);
            this.BackButton.TabIndex = 17;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 731);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ConfirmLogIn);
            this.Controls.Add(this.accountlabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.PassUser);
            this.Controls.Add(this.NameUser);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.LogInChoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.LogInChoice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox LogInChoice;
        private System.Windows.Forms.TextBox NameUser;
        private System.Windows.Forms.TextBox PassUser;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.RadioButton GenderMan;
        private System.Windows.Forms.RadioButton GenderWoman;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label accountlabel;
        private System.Windows.Forms.Button ConfirmLogIn;
        private System.Windows.Forms.Button BackButton;
    }
}