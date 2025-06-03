namespace MusicalConcertApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            homePagePanel = new Panel();
            richTextBox1 = new RichTextBox();
            pictureBox2 = new PictureBox();
            HomeButton = new Button();
            profileButton = new Button();
            concertsButton = new Button();
            userName = new Label();
            LoginSlashRegisterPanel = new Panel();
            loginErrorSpan = new Label();
            registerErrorSpan = new Label();
            loginButton = new Button();
            label6 = new Label();
            label7 = new Label();
            loginPasswordTextBox = new TextBox();
            loginNameTextBox = new TextBox();
            registerButton = new Button();
            label5 = new Label();
            nameLabel = new Label();
            registerPasswordTextBox = new TextBox();
            registerNameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            concertsPanel = new FlowLayoutPanel();
            concertPanel = new Panel();
            signButton = new Button();
            concertGenreLabel = new Label();
            concertDescription = new RichTextBox();
            concertTitle = new Label();
            accSignOutButton = new Button();
            userPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            homePagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            LoginSlashRegisterPanel.SuspendLayout();
            concertPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BackgroundImage = Properties.Resources.BG57;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(813, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // homePagePanel
            // 
            homePagePanel.BackColor = Color.Transparent;
            homePagePanel.BackgroundImage = Properties.Resources.rm218_bb_07;
            homePagePanel.BackgroundImageLayout = ImageLayout.Stretch;
            homePagePanel.Controls.Add(richTextBox1);
            homePagePanel.Controls.Add(pictureBox2);
            homePagePanel.Location = new Point(-5, 45);
            homePagePanel.Name = "homePagePanel";
            homePagePanel.Size = new Size(813, 409);
            homePagePanel.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.MidnightBlue;
            richTextBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.FromArgb(128, 128, 255);
            richTextBox1.Location = new Point(170, 57);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(481, 258);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "Добре дошли в приложението за музикални концерти. Тук можете да разглеждате и да купувате билети за концерти";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.rm218_bb_07;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(807, 406);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // HomeButton
            // 
            HomeButton.BackColor = Color.White;
            HomeButton.BackgroundImage = Properties.Resources.home;
            HomeButton.BackgroundImageLayout = ImageLayout.Stretch;
            HomeButton.ForeColor = SystemColors.ControlText;
            HomeButton.Location = new Point(12, 12);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(29, 27);
            HomeButton.TabIndex = 2;
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += button1_Click;
            // 
            // profileButton
            // 
            profileButton.BackColor = Color.White;
            profileButton.BackgroundImage = Properties.Resources.user;
            profileButton.BackgroundImageLayout = ImageLayout.Stretch;
            profileButton.ForeColor = SystemColors.ControlText;
            profileButton.Location = new Point(759, 12);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(29, 27);
            profileButton.TabIndex = 3;
            profileButton.UseVisualStyleBackColor = false;
            profileButton.Click += profileButton_Click;
            // 
            // concertsButton
            // 
            concertsButton.BackColor = Color.White;
            concertsButton.BackgroundImage = Properties.Resources.music;
            concertsButton.BackgroundImageLayout = ImageLayout.Stretch;
            concertsButton.ForeColor = SystemColors.ControlText;
            concertsButton.Location = new Point(72, 12);
            concertsButton.Name = "concertsButton";
            concertsButton.Size = new Size(29, 27);
            concertsButton.TabIndex = 4;
            concertsButton.UseVisualStyleBackColor = false;
            concertsButton.Click += concertsButton_Click;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.BackColor = SystemColors.ActiveCaptionText;
            userName.ForeColor = SystemColors.ControlLightLight;
            userName.Location = new Point(702, 18);
            userName.Name = "userName";
            userName.Size = new Size(38, 15);
            userName.TabIndex = 5;
            userName.Text = "label2";
            userName.Visible = false;
            // 
            // LoginSlashRegisterPanel
            // 
            LoginSlashRegisterPanel.BackColor = Color.Transparent;
            LoginSlashRegisterPanel.BackgroundImage = Properties.Resources.rm218_bb_07;
            LoginSlashRegisterPanel.BackgroundImageLayout = ImageLayout.Stretch;
            LoginSlashRegisterPanel.Controls.Add(loginErrorSpan);
            LoginSlashRegisterPanel.Controls.Add(registerErrorSpan);
            LoginSlashRegisterPanel.Controls.Add(loginButton);
            LoginSlashRegisterPanel.Controls.Add(label6);
            LoginSlashRegisterPanel.Controls.Add(label7);
            LoginSlashRegisterPanel.Controls.Add(loginPasswordTextBox);
            LoginSlashRegisterPanel.Controls.Add(loginNameTextBox);
            LoginSlashRegisterPanel.Controls.Add(registerButton);
            LoginSlashRegisterPanel.Controls.Add(label5);
            LoginSlashRegisterPanel.Controls.Add(nameLabel);
            LoginSlashRegisterPanel.Controls.Add(registerPasswordTextBox);
            LoginSlashRegisterPanel.Controls.Add(registerNameTextBox);
            LoginSlashRegisterPanel.Controls.Add(label4);
            LoginSlashRegisterPanel.Controls.Add(label3);
            LoginSlashRegisterPanel.Controls.Add(label2);
            LoginSlashRegisterPanel.Location = new Point(-5, 45);
            LoginSlashRegisterPanel.Name = "LoginSlashRegisterPanel";
            LoginSlashRegisterPanel.Size = new Size(810, 406);
            LoginSlashRegisterPanel.TabIndex = 6;
            LoginSlashRegisterPanel.Visible = false;
            // 
            // loginErrorSpan
            // 
            loginErrorSpan.AutoSize = true;
            loginErrorSpan.BackColor = Color.Transparent;
            loginErrorSpan.ForeColor = Color.Red;
            loginErrorSpan.Location = new Point(528, 347);
            loginErrorSpan.Name = "loginErrorSpan";
            loginErrorSpan.Size = new Size(0, 15);
            loginErrorSpan.TabIndex = 14;
            loginErrorSpan.Visible = false;
            // 
            // registerErrorSpan
            // 
            registerErrorSpan.AutoSize = true;
            registerErrorSpan.BackColor = Color.Transparent;
            registerErrorSpan.ForeColor = Color.Red;
            registerErrorSpan.Location = new Point(77, 347);
            registerErrorSpan.Name = "registerErrorSpan";
            registerErrorSpan.Size = new Size(0, 15);
            registerErrorSpan.TabIndex = 13;
            registerErrorSpan.Visible = false;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Transparent;
            loginButton.BackgroundImage = Properties.Resources.BG57;
            loginButton.BackgroundImageLayout = ImageLayout.Stretch;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.ForeColor = SystemColors.ButtonFace;
            loginButton.Location = new Point(549, 292);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(102, 23);
            loginButton.TabIndex = 12;
            loginButton.Text = "Влез";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(562, 197);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 11;
            label6.Text = "Парола";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(571, 90);
            label7.Name = "label7";
            label7.Size = new Size(49, 25);
            label7.TabIndex = 10;
            label7.Text = "Име";
            // 
            // loginPasswordTextBox
            // 
            loginPasswordTextBox.BackColor = Color.DarkSlateBlue;
            loginPasswordTextBox.ForeColor = SystemColors.ButtonFace;
            loginPasswordTextBox.Location = new Point(515, 237);
            loginPasswordTextBox.Name = "loginPasswordTextBox";
            loginPasswordTextBox.Size = new Size(180, 23);
            loginPasswordTextBox.TabIndex = 9;
            // 
            // loginNameTextBox
            // 
            loginNameTextBox.BackColor = Color.DarkSlateBlue;
            loginNameTextBox.ForeColor = SystemColors.ButtonFace;
            loginNameTextBox.Location = new Point(515, 127);
            loginNameTextBox.Name = "loginNameTextBox";
            loginNameTextBox.Size = new Size(180, 23);
            loginNameTextBox.TabIndex = 8;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.Transparent;
            registerButton.BackgroundImage = Properties.Resources.BG57;
            registerButton.BackgroundImageLayout = ImageLayout.Stretch;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.ForeColor = SystemColors.ButtonFace;
            registerButton.Location = new Point(95, 292);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(102, 23);
            registerButton.TabIndex = 7;
            registerButton.Text = "Регистрирай се";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(108, 197);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 6;
            label5.Text = "Парола";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = SystemColors.ButtonFace;
            nameLabel.Location = new Point(117, 90);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 25);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Име";
            // 
            // registerPasswordTextBox
            // 
            registerPasswordTextBox.BackColor = Color.DarkSlateBlue;
            registerPasswordTextBox.ForeColor = SystemColors.ButtonFace;
            registerPasswordTextBox.Location = new Point(61, 237);
            registerPasswordTextBox.Name = "registerPasswordTextBox";
            registerPasswordTextBox.Size = new Size(180, 23);
            registerPasswordTextBox.TabIndex = 4;
            // 
            // registerNameTextBox
            // 
            registerNameTextBox.BackColor = Color.DarkSlateBlue;
            registerNameTextBox.ForeColor = SystemColors.ButtonFace;
            registerNameTextBox.Location = new Point(61, 127);
            registerNameTextBox.MaxLength = 8;
            registerNameTextBox.Name = "registerNameTextBox";
            registerNameTextBox.Size = new Size(180, 23);
            registerNameTextBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(359, 74);
            label4.Name = "label4";
            label4.Size = new Size(51, 30);
            label4.TabIndex = 2;
            label4.Text = "или";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(490, 40);
            label3.Name = "label3";
            label3.Size = new Size(217, 30);
            label3.TabIndex = 1;
            label3.Text = "ВЛЕЗ В АКАУНТА СИ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(61, 40);
            label2.Name = "label2";
            label2.Size = new Size(186, 30);
            label2.TabIndex = 0;
            label2.Text = "РЕГИСТРИРАЙ СЕ";
            // 
            // concertsPanel
            // 
            concertsPanel.AutoScroll = true;
            concertsPanel.BackColor = Color.Transparent;
            concertsPanel.BackgroundImage = Properties.Resources.rm218_bb_07;
            concertsPanel.BackgroundImageLayout = ImageLayout.Stretch;
            concertsPanel.Location = new Point(-5, 48);
            concertsPanel.Name = "concertsPanel";
            concertsPanel.Size = new Size(806, 406);
            concertsPanel.TabIndex = 5;
            concertsPanel.Paint += concertsPanel_Paint;
            // 
            // concertPanel
            // 
            concertPanel.BackColor = Color.Transparent;
            concertPanel.BackgroundImage = Properties.Resources.rm218_bb_07;
            concertPanel.BackgroundImageLayout = ImageLayout.Stretch;
            concertPanel.Controls.Add(signButton);
            concertPanel.Controls.Add(concertGenreLabel);
            concertPanel.Controls.Add(concertDescription);
            concertPanel.Controls.Add(concertTitle);
            concertPanel.Location = new Point(0, 48);
            concertPanel.Name = "concertPanel";
            concertPanel.Size = new Size(804, 403);
            concertPanel.TabIndex = 0;
            // 
            // signButton
            // 
            signButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signButton.Location = new Point(540, 365);
            signButton.Name = "signButton";
            signButton.Size = new Size(95, 23);
            signButton.TabIndex = 3;
            signButton.Text = "Запиши се";
            signButton.UseVisualStyleBackColor = true;
            signButton.Click += signButton_Click;
            // 
            // concertGenreLabel
            // 
            concertGenreLabel.AutoSize = true;
            concertGenreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            concertGenreLabel.ForeColor = SystemColors.ControlLightLight;
            concertGenreLabel.Location = new Point(23, 115);
            concertGenreLabel.Name = "concertGenreLabel";
            concertGenreLabel.Size = new Size(52, 21);
            concertGenreLabel.TabIndex = 2;
            concertGenreLabel.Text = "Genre";
            // 
            // concertDescription
            // 
            concertDescription.Location = new Point(23, 163);
            concertDescription.Name = "concertDescription";
            concertDescription.Size = new Size(274, 225);
            concertDescription.TabIndex = 1;
            concertDescription.Text = "Concert Description";
            // 
            // concertTitle
            // 
            concertTitle.AutoSize = true;
            concertTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            concertTitle.ForeColor = SystemColors.ControlLight;
            concertTitle.Location = new Point(23, 83);
            concertTitle.Name = "concertTitle";
            concertTitle.Size = new Size(60, 32);
            concertTitle.TabIndex = 0;
            concertTitle.Text = "Title";
            // 
            // accSignOutButton
            // 
            accSignOutButton.BackColor = Color.Black;
            accSignOutButton.FlatAppearance.BorderSize = 0;
            accSignOutButton.FlatStyle = FlatStyle.Flat;
            accSignOutButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accSignOutButton.ForeColor = Color.Red;
            accSignOutButton.Location = new Point(621, 12);
            accSignOutButton.Name = "accSignOutButton";
            accSignOutButton.Size = new Size(75, 27);
            accSignOutButton.TabIndex = 4;
            accSignOutButton.Text = "Излез";
            accSignOutButton.UseVisualStyleBackColor = false;
            accSignOutButton.Visible = false;
            accSignOutButton.Click += accSignOutButton_Click;
            // 
            // userPanel
            // 
            userPanel.BackColor = Color.Transparent;
            userPanel.BackgroundImage = Properties.Resources.rm218_bb_07;
            userPanel.BackgroundImageLayout = ImageLayout.Stretch;
            userPanel.Location = new Point(0, 45);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(801, 403);
            userPanel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(accSignOutButton);
            Controls.Add(userName);
            Controls.Add(concertsButton);
            Controls.Add(profileButton);
            Controls.Add(HomeButton);
            Controls.Add(pictureBox1);
            Controls.Add(homePagePanel);
            Controls.Add(userPanel);
            Controls.Add(concertsPanel);
            Controls.Add(concertPanel);
            Controls.Add(LoginSlashRegisterPanel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            homePagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            LoginSlashRegisterPanel.ResumeLayout(false);
            LoginSlashRegisterPanel.PerformLayout();
            concertPanel.ResumeLayout(false);
            concertPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel homePagePanel;
        private PictureBox pictureBox2;
        private Button HomeButton;
        private Button profileButton;
        private Button concertsButton;
        private RichTextBox richTextBox1;
        private Label userName;
        private Panel LoginSlashRegisterPanel;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label nameLabel;
        private TextBox registerPasswordTextBox;
        private TextBox registerNameTextBox;
        private Button registerButton;
        private Button loginButton;
        private Label label6;
        private Label label7;
        private TextBox loginPasswordTextBox;
        private TextBox loginNameTextBox;
        private Label loginErrorSpan;
        private Label registerErrorSpan;
        private FlowLayoutPanel concertsPanel;
        private Panel concertPanel;
        private Label concertGenreLabel;
        private RichTextBox concertDescription;
        private Label concertTitle;
        private Button signButton;
        private FlowLayoutPanel userPanel;
        private Button accSignOutButton;
    }
}
