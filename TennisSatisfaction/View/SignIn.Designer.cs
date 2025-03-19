
namespace TennisSatisfaction
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            usernameLabel = new Label();
            passwordLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            signInButton = new Button();
            tennispPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)tennispPictureBox).BeginInit();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(541, 181);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(99, 22);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username :";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(541, 229);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(99, 22);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password :";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.WhiteSmoke;
            usernameTextBox.CharacterCasing = CharacterCasing.Lower;
            usernameTextBox.Location = new Point(657, 180);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(164, 23);
            usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.WhiteSmoke;
            passwordTextBox.Location = new Point(657, 228);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(164, 23);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // signInButton
            // 
            signInButton.BackColor = Color.DarkTurquoise;
            signInButton.FlatAppearance.BorderSize = 0;
            signInButton.FlatStyle = FlatStyle.Popup;
            signInButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signInButton.Location = new Point(676, 291);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(125, 50);
            signInButton.TabIndex = 4;
            signInButton.Text = "sign in";
            signInButton.UseVisualStyleBackColor = false;
            signInButton.Click += signInButton_Click;
            // 
            // tennispPictureBox
            // 
            tennispPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            tennispPictureBox.Image = (Image)resources.GetObject("tennispPictureBox.Image");
            tennispPictureBox.Location = new Point(87, 70);
            tennispPictureBox.Name = "tennispPictureBox";
            tennispPictureBox.Size = new Size(345, 365);
            tennispPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            tennispPictureBox.TabIndex = 5;
            tennispPictureBox.TabStop = false;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(968, 525);
            Controls.Add(tennispPictureBox);
            Controls.Add(signInButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Name = "SignIn";
            ((System.ComponentModel.ISupportInitialize)tennispPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button signInButton;
        private PictureBox tennispPictureBox;
    }
}
