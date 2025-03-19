namespace TennisSatisfaction.View
{
    partial class AdminPage
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
            splitContainer1 = new SplitContainer();
            RegisterStudentButton = new Button();
            studentsButton = new Button();
            questionsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(RegisterStudentButton);
            splitContainer1.Panel1.Controls.Add(studentsButton);
            splitContainer1.Panel1.Controls.Add(questionsButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackgroundImage = Properties.Resources._31_1024x649;
            splitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Size = new Size(968, 525);
            splitContainer1.SplitterDistance = 158;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 0;
            // 
            // RegisterStudentButton
            // 
            RegisterStudentButton.BackColor = Color.Yellow;
            RegisterStudentButton.FlatStyle = FlatStyle.Flat;
            RegisterStudentButton.ForeColor = Color.Green;
            RegisterStudentButton.Location = new Point(0, 116);
            RegisterStudentButton.Name = "RegisterStudentButton";
            RegisterStudentButton.Size = new Size(155, 59);
            RegisterStudentButton.TabIndex = 2;
            RegisterStudentButton.Text = "Register a student";
            RegisterStudentButton.UseVisualStyleBackColor = false;
            RegisterStudentButton.Click += RegisterStudentButton_Click;
            // 
            // studentsButton
            // 
            studentsButton.BackColor = Color.Yellow;
            studentsButton.FlatStyle = FlatStyle.Flat;
            studentsButton.ForeColor = Color.Green;
            studentsButton.Location = new Point(0, 58);
            studentsButton.Name = "studentsButton";
            studentsButton.Size = new Size(155, 59);
            studentsButton.TabIndex = 1;
            studentsButton.Text = "Students and Answers";
            studentsButton.UseVisualStyleBackColor = false;
            studentsButton.Click += studentsButton_Click;
            // 
            // questionsButton
            // 
            questionsButton.BackColor = Color.Yellow;
            questionsButton.FlatStyle = FlatStyle.Flat;
            questionsButton.ForeColor = Color.Green;
            questionsButton.Location = new Point(0, 0);
            questionsButton.Name = "questionsButton";
            questionsButton.Size = new Size(155, 59);
            questionsButton.TabIndex = 0;
            questionsButton.Text = "Questions";
            questionsButton.UseVisualStyleBackColor = false;
            questionsButton.Click += questionsButton_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(968, 525);
            Controls.Add(splitContainer1);
            Name = "AdminPage";
            Text = "AdminPage";
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button studentsButton;
        private Button questionsButton;
        private Button RegisterStudentButton;
    }
}