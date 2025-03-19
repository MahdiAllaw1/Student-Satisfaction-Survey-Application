namespace TennisSatisfaction.View
{
    partial class StudentRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRegister));
            fullnameLabel = new Label();
            genderLabel = new Label();
            emailLabel = new Label();
            universityLabel = new Label();
            courseTimeLabel = new Label();
            firstnameTextBox = new TextBox();
            lastnameTextBox = new TextBox();
            checkMale = new CheckBox();
            checkFemale = new CheckBox();
            checkOther = new CheckBox();
            emailTextBox = new TextBox();
            universityComboBox = new ComboBox();
            courseTimeComboBox = new ComboBox();
            letsDoItLabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            nextButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // fullnameLabel
            // 
            fullnameLabel.AutoSize = true;
            fullnameLabel.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullnameLabel.Location = new Point(151, 155);
            fullnameLabel.Name = "fullnameLabel";
            fullnameLabel.Size = new Size(78, 19);
            fullnameLabel.TabIndex = 0;
            fullnameLabel.Text = "fullname :";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderLabel.Location = new Point(157, 213);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(68, 19);
            genderLabel.TabIndex = 1;
            genderLabel.Text = "Gender :";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(164, 265);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(58, 19);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email :";
            // 
            // universityLabel
            // 
            universityLabel.AutoSize = true;
            universityLabel.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            universityLabel.Location = new Point(150, 323);
            universityLabel.Name = "universityLabel";
            universityLabel.Size = new Size(89, 19);
            universityLabel.TabIndex = 3;
            universityLabel.Text = "University :";
            // 
            // courseTimeLabel
            // 
            courseTimeLabel.AutoSize = true;
            courseTimeLabel.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseTimeLabel.Location = new Point(142, 383);
            courseTimeLabel.Name = "courseTimeLabel";
            courseTimeLabel.Size = new Size(105, 19);
            courseTimeLabel.TabIndex = 4;
            courseTimeLabel.Text = "Course Time :";
            // 
            // firstnameTextBox
            // 
            firstnameTextBox.BackColor = Color.WhiteSmoke;
            firstnameTextBox.Location = new Point(279, 154);
            firstnameTextBox.Name = "firstnameTextBox";
            firstnameTextBox.Size = new Size(203, 23);
            firstnameTextBox.TabIndex = 5;
            firstnameTextBox.Text = "First name (prenom)";
            firstnameTextBox.UseWaitCursor = true;
            firstnameTextBox.Enter += firstnameTextBox_Enter;
            // 
            // lastnameTextBox
            // 
            lastnameTextBox.BackColor = Color.WhiteSmoke;
            lastnameTextBox.Location = new Point(556, 154);
            lastnameTextBox.Name = "lastnameTextBox";
            lastnameTextBox.Size = new Size(203, 23);
            lastnameTextBox.TabIndex = 6;
            lastnameTextBox.Text = "Last name (nom)";
            lastnameTextBox.Enter += lastnameTextBox_Enter;
            // 
            // checkMale
            // 
            checkMale.AutoSize = true;
            checkMale.BackColor = Color.White;
            checkMale.Location = new Point(279, 215);
            checkMale.Name = "checkMale";
            checkMale.Size = new Size(52, 19);
            checkMale.TabIndex = 7;
            checkMale.Text = "Male";
            checkMale.UseVisualStyleBackColor = false;
            // 
            // checkFemale
            // 
            checkFemale.AutoSize = true;
            checkFemale.Location = new Point(434, 215);
            checkFemale.Name = "checkFemale";
            checkFemale.Size = new Size(64, 19);
            checkFemale.TabIndex = 8;
            checkFemale.Text = "Female";
            checkFemale.UseVisualStyleBackColor = true;
            // 
            // checkOther
            // 
            checkOther.AutoSize = true;
            checkOther.Location = new Point(590, 215);
            checkOther.Name = "checkOther";
            checkOther.Size = new Size(56, 19);
            checkOther.TabIndex = 9;
            checkOther.Text = "Other";
            checkOther.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.WhiteSmoke;
            emailTextBox.Location = new Point(279, 264);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(480, 23);
            emailTextBox.TabIndex = 10;
            emailTextBox.Text = "@example.com";
            emailTextBox.Enter += emailTextBox_Enter;
            // 
            // universityComboBox
            // 
            universityComboBox.BackColor = Color.WhiteSmoke;
            universityComboBox.FormattingEnabled = true;
            universityComboBox.Items.AddRange(new object[] { "INP Phelma", "INP Ensimag", "INP Pagora", "UGA", "INP ENSE3" });
            universityComboBox.Location = new Point(279, 322);
            universityComboBox.Name = "universityComboBox";
            universityComboBox.Size = new Size(121, 23);
            universityComboBox.TabIndex = 11;
            // 
            // courseTimeComboBox
            // 
            courseTimeComboBox.BackColor = Color.WhiteSmoke;
            courseTimeComboBox.FormattingEnabled = true;
            courseTimeComboBox.Items.AddRange(new object[] { "Lundi 8:00-10:00", "Jeudi 13:30-15:30" });
            courseTimeComboBox.Location = new Point(279, 382);
            courseTimeComboBox.Name = "courseTimeComboBox";
            courseTimeComboBox.Size = new Size(121, 23);
            courseTimeComboBox.TabIndex = 12;
            // 
            // letsDoItLabel
            // 
            letsDoItLabel.AutoSize = true;
            letsDoItLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            letsDoItLabel.Location = new Point(408, 71);
            letsDoItLabel.Name = "letsDoItLabel";
            letsDoItLabel.Size = new Size(142, 31);
            letsDoItLabel.TabIndex = 13;
            letsDoItLabel.Text = "Let's Do It !";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(87, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(785, 40);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(92, 86);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(423, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.Yellow;
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatStyle = FlatStyle.Popup;
            nextButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextButton.Location = new Point(421, 438);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(125, 50);
            nextButton.TabIndex = 19;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // StudentRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(968, 525);
            Controls.Add(nextButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(letsDoItLabel);
            Controls.Add(courseTimeComboBox);
            Controls.Add(universityComboBox);
            Controls.Add(emailTextBox);
            Controls.Add(checkOther);
            Controls.Add(checkFemale);
            Controls.Add(checkMale);
            Controls.Add(lastnameTextBox);
            Controls.Add(firstnameTextBox);
            Controls.Add(courseTimeLabel);
            Controls.Add(universityLabel);
            Controls.Add(emailLabel);
            Controls.Add(genderLabel);
            Controls.Add(fullnameLabel);
            Name = "StudentRegister";
            Text = "StudentRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fullnameLabel;
        private Label genderLabel;
        private Label emailLabel;
        private Label universityLabel;
        private Label courseTimeLabel;
        private TextBox firstnameTextBox;
        private TextBox lastnameTextBox;
        private CheckBox checkMale;
        private CheckBox checkFemale;
        private CheckBox checkOther;
        private TextBox emailTextBox;
        private ComboBox universityComboBox;
        private ComboBox courseTimeComboBox;
        private Label letsDoItLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button nextButton;
    }
}