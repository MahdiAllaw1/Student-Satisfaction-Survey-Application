namespace TennisSatisfaction.View.UserControls
{
    partial class StudentsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            searchByQuestionButton = new Button();
            searchByGenderButton = new Button();
            searchByCourseTimeButton = new Button();
            searchByUniversityButton = new Button();
            searchByNameButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(searchByQuestionButton);
            splitContainer1.Panel1.Controls.Add(searchByGenderButton);
            splitContainer1.Panel1.Controls.Add(searchByCourseTimeButton);
            splitContainer1.Panel1.Controls.Add(searchByUniversityButton);
            splitContainer1.Panel1.Controls.Add(searchByNameButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Size = new Size(810, 525);
            splitContainer1.SplitterDistance = 64;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 0;
            // 
            // searchByQuestionButton
            // 
            searchByQuestionButton.BackColor = Color.Yellow;
            searchByQuestionButton.FlatStyle = FlatStyle.Flat;
            searchByQuestionButton.ForeColor = Color.Green;
            searchByQuestionButton.Location = new Point(651, 0);
            searchByQuestionButton.Name = "searchByQuestionButton";
            searchByQuestionButton.Size = new Size(159, 61);
            searchByQuestionButton.TabIndex = 4;
            searchByQuestionButton.Text = "search by question";
            searchByQuestionButton.UseVisualStyleBackColor = false;
            searchByQuestionButton.Click += searchByQuestionButton_Click;
            // 
            // searchByGenderButton
            // 
            searchByGenderButton.BackColor = Color.Yellow;
            searchByGenderButton.FlatStyle = FlatStyle.Flat;
            searchByGenderButton.ForeColor = Color.Green;
            searchByGenderButton.Location = new Point(486, 0);
            searchByGenderButton.Name = "searchByGenderButton";
            searchByGenderButton.Size = new Size(169, 61);
            searchByGenderButton.TabIndex = 3;
            searchByGenderButton.Text = "search by gender";
            searchByGenderButton.UseVisualStyleBackColor = false;
            searchByGenderButton.Click += searchByGenderButton_Click;
            // 
            // searchByCourseTimeButton
            // 
            searchByCourseTimeButton.BackColor = Color.Yellow;
            searchByCourseTimeButton.FlatStyle = FlatStyle.Flat;
            searchByCourseTimeButton.ForeColor = Color.Green;
            searchByCourseTimeButton.Location = new Point(321, 0);
            searchByCourseTimeButton.Name = "searchByCourseTimeButton";
            searchByCourseTimeButton.Size = new Size(169, 61);
            searchByCourseTimeButton.TabIndex = 2;
            searchByCourseTimeButton.Text = "search by course time";
            searchByCourseTimeButton.UseVisualStyleBackColor = false;
            searchByCourseTimeButton.Click += searchByCourseTimeButton_Click;
            // 
            // searchByUniversityButton
            // 
            searchByUniversityButton.BackColor = Color.Yellow;
            searchByUniversityButton.FlatStyle = FlatStyle.Flat;
            searchByUniversityButton.ForeColor = Color.Green;
            searchByUniversityButton.Location = new Point(157, 0);
            searchByUniversityButton.Name = "searchByUniversityButton";
            searchByUniversityButton.Size = new Size(167, 61);
            searchByUniversityButton.TabIndex = 1;
            searchByUniversityButton.Text = "search by university";
            searchByUniversityButton.UseVisualStyleBackColor = false;
            searchByUniversityButton.Click += searchByUniversityButton_Click;
            // 
            // searchByNameButton
            // 
            searchByNameButton.BackColor = Color.Yellow;
            searchByNameButton.FlatStyle = FlatStyle.Flat;
            searchByNameButton.ForeColor = Color.Green;
            searchByNameButton.Location = new Point(0, 0);
            searchByNameButton.Name = "searchByNameButton";
            searchByNameButton.Size = new Size(159, 61);
            searchByNameButton.TabIndex = 0;
            searchByNameButton.Text = "search by name";
            searchByNameButton.UseVisualStyleBackColor = false;
            searchByNameButton.Click += searchByNameButton_Click;
            // 
            // StudentsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "StudentsUserControl";
            Size = new Size(810, 525);
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button searchByQuestionButton;
        private Button searchByGenderButton;
        private Button searchByCourseTimeButton;
        private Button searchByUniversityButton;
        private Button searchByNameButton;
    }
}
