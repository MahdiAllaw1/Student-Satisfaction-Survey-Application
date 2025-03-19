namespace TennisSatisfaction.View.UserControls
{
    partial class QuestionsUserControl
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
            questionsDataGridView = new DataGridView();
            addQuestionButton = new Button();
            deleteQuestionButton = new Button();
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // questionsDataGridView
            // 
            questionsDataGridView.AllowUserToAddRows = false;
            questionsDataGridView.AllowUserToDeleteRows = false;
            questionsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            questionsDataGridView.BackgroundColor = Color.WhiteSmoke;
            questionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsDataGridView.Location = new Point(73, 257);
            questionsDataGridView.Name = "questionsDataGridView";
            questionsDataGridView.ReadOnly = true;
            questionsDataGridView.Size = new Size(642, 244);
            questionsDataGridView.TabIndex = 0;
            // 
            // addQuestionButton
            // 
            addQuestionButton.BackColor = Color.Yellow;
            addQuestionButton.FlatStyle = FlatStyle.Popup;
            addQuestionButton.ForeColor = Color.Green;
            addQuestionButton.Location = new Point(73, 31);
            addQuestionButton.Name = "addQuestionButton";
            addQuestionButton.Size = new Size(191, 37);
            addQuestionButton.TabIndex = 1;
            addQuestionButton.Text = "Add a Question";
            addQuestionButton.UseVisualStyleBackColor = false;
            addQuestionButton.Click += addQuestionButton_Click;
            // 
            // deleteQuestionButton
            // 
            deleteQuestionButton.BackColor = Color.Yellow;
            deleteQuestionButton.FlatStyle = FlatStyle.Popup;
            deleteQuestionButton.ForeColor = Color.Green;
            deleteQuestionButton.Location = new Point(524, 31);
            deleteQuestionButton.Name = "deleteQuestionButton";
            deleteQuestionButton.Size = new Size(191, 37);
            deleteQuestionButton.TabIndex = 2;
            deleteQuestionButton.Text = "Delete a question";
            deleteQuestionButton.UseVisualStyleBackColor = false;
            deleteQuestionButton.Click += deleteQuestionButton_Click;
            // 
            // QuestionsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(deleteQuestionButton);
            Controls.Add(addQuestionButton);
            Controls.Add(questionsDataGridView);
            Name = "QuestionsUserControl";
            Size = new Size(810, 525);
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView questionsDataGridView;
        private Button addQuestionButton;
        private Button deleteQuestionButton;
    }
}
