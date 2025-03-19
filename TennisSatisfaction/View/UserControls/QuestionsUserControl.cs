using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TennisSatisfaction.Model;
using TennisSatisfactionSurveySystem;

namespace TennisSatisfaction.View.UserControls
{
    public partial class QuestionsUserControl : UserControl
    {
        private TextBox questionTextBox;
        private TextBox questionTextFrBox;
        private ComboBox questionTypeComboBox;
        private ComboBox questionIdComboBox;
        private Button executeButton;
        private Label lblQuestionEn, lblQuestionFr, lblQuestionType, lblSelectQuestion;
        private bool isAddingQuestion = false;

        private MySQLController dbController = new MySQLController();

        public QuestionsUserControl()
        {
            InitializeComponent();
            LoadQuestionsToGrid();
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            ClearControls();
            isAddingQuestion = true;

            // Question (English)
            lblQuestionEn = new Label { Text = "Question (EN):", Location = new Point(300, 57), Size = new Size(100, 20) };
            questionTextBox = new TextBox { Location = new Point(300, 80), Size = new Size(200, 25) };

            // Question (French)
            lblQuestionFr = new Label { Text = "Question (FR):", Location = new Point(300, 110), Size = new Size(100, 20) };
            questionTextFrBox = new TextBox { Location = new Point(300, 130), Size = new Size(200, 25) };

            // Question Type
            lblQuestionType = new Label { Text = "Type:", Location = new Point(300, 160), Size = new Size(100, 20) };
            questionTypeComboBox = new ComboBox
            {
                Location = new Point(300, 180),
                Size = new Size(200, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            questionTypeComboBox.Items.AddRange(new string[] { "scale", "yes_no", "text" });

            // Execute Button
            executeButton = new Button
            {
                Text = "Execute",
                Location = new Point(345, 220),
                BackColor = Color.Yellow,
                ForeColor = Color.Green,
                FlatStyle = FlatStyle.Popup,
                Size = new Size(100, 30)
            };
            executeButton.Click += ExecuteButton_Click;

            // Add controls to UserControl
            Controls.Add(lblQuestionEn);
            Controls.Add(questionTextBox);
            Controls.Add(lblQuestionFr);
            Controls.Add(questionTextFrBox);
            Controls.Add(lblQuestionType);
            Controls.Add(questionTypeComboBox);
            Controls.Add(executeButton);
        }

        private void deleteQuestionButton_Click(object sender, EventArgs e)
        {
            ClearControls();
            isAddingQuestion = false;

            // Label for selecting question ID
            lblSelectQuestion = new Label { Text = "Select Question:", Location = new Point(300, 160), Size = new Size(120, 20) };

            // ComboBox for question ID
            questionIdComboBox = new ComboBox
            {
                Location = new Point(300, 180),
                Size = new Size(200, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            LoadQuestionIds();

            // Execute Button
            executeButton = new Button
            {
                Text = "Execute",
                Location = new Point(345, 220),
                BackColor = Color.Yellow,
                ForeColor = Color.Green,
                FlatStyle = FlatStyle.Popup,
                Size = new Size(100, 30)
            };
            executeButton.Click += ExecuteButton_Click;

            // Add controls to UserControl
            Controls.Add(lblSelectQuestion);
            Controls.Add(questionIdComboBox);
            Controls.Add(executeButton);
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            if (isAddingQuestion)
            {
                // Add question to the database
                string questionEn = questionTextBox.Text.Trim();
                string questionFr = questionTextFrBox.Text.Trim();
                string questionType = questionTypeComboBox.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(questionEn) && !string.IsNullOrEmpty(questionFr) && !string.IsNullOrEmpty(questionType))
                {
                    bool success = dbController.AddQuestion(questionEn, questionFr, questionType);
                    MessageBox.Show(success ? "Question added successfully!" : "Failed to add question.");
                    LoadQuestionsToGrid();
                }
                else
                {
                    MessageBox.Show("Please fill in all fields.");
                }
            }
            else
            {
                // Delete question from the database
                if (questionIdComboBox.SelectedItem != null)
                {
                    int questionId = Convert.ToInt32(questionIdComboBox.SelectedItem);
                    bool success = dbController.DeleteQuestion(questionId);
                    MessageBox.Show(success ? "Question deleted successfully!" : "Failed to delete question.");
                    LoadQuestionsToGrid();
                }
                else
                {
                    MessageBox.Show("Please select a question ID.");
                }
            }

            ClearControls();
        }

        private void LoadQuestionIds()
        {
            questionIdComboBox.Items.Clear();
            List<Question> questions = dbController.GetQuestions();
            foreach (var question in questions)
            {
                questionIdComboBox.Items.Add(question.Id);
            }
        }

        public void LoadQuestionsToGrid()
        {
            DataTable questionsTable = dbController.GetQuestionsDataTable();
            questionsDataGridView.DataSource = questionsTable;
        }

        private void ClearControls()
        {
            Controls.Remove(lblQuestionEn);
            Controls.Remove(questionTextBox);
            Controls.Remove(lblQuestionFr);
            Controls.Remove(questionTextFrBox);
            Controls.Remove(lblQuestionType);
            Controls.Remove(questionTypeComboBox);
            Controls.Remove(lblSelectQuestion);
            Controls.Remove(questionIdComboBox);
            Controls.Remove(executeButton);
        }
    }
}
