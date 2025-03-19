using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TennisSatisfaction.Controller;
using TennisSatisfaction.Model;
using TennisSatisfactionSurveySystem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TennisSatisfaction.View
{
    public partial class Survey : Form
    {
        private StudentController studentController;
        private QuestionController questionController;
        private Question nextQuestion;
        private bool text_english;
        private CheckBox yesCheckBox;
        private CheckBox noCheckBox;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private List<CheckBox> scaleCheckBoxes = new List<CheckBox>();
        public Survey(StudentController stController)
        {
            InitializeComponent();
            this.AcceptButton = suivantButton;
            studentController = stController;
            questionController = new QuestionController();
            nextQuestion = questionController.GetNextQuestion();
            if (nextQuestion != null)
            {
                DisplayQuestion(nextQuestion.QuestionText);
                DisplayAnswerOptions(nextQuestion.QuestionType);
                text_english = true;
            }
            progressBar.Minimum = 1;
            progressBar.Maximum = questionController.GetNumberOfQuestions();
        }

        private void suivantButton_Click(object sender, EventArgs e)
        {
            if (AddAnswer() == true)
            {
                nextQuestion = questionController.GetNextQuestion();
                if (nextQuestion != null)
                {
                    DisplayQuestion(nextQuestion.QuestionText);
                    DisplayAnswerOptions(nextQuestion.QuestionType);
                    text_english = true;
                    UpdateProgressBar();
                }
                else
                {
                    // Open StudentRegister form and pass the existing controller
                    /*StudentRegister registerForm = new StudentRegister(studentController);
                    registerForm.Show();*/
                    studentController.SaveAllStudentsToDatabase();

                    // Close the current form if necessary
                    this.Close();
                }
            }
        }

        void UpdateProgressBar()
        {
            progressBar.Value++;
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            if (text_english == true)
            {
                DisplayQuestion(nextQuestion.QuestionText_fr);
                text_english = false;
            }
            else
            {
                DisplayQuestion(nextQuestion.QuestionText);
                text_english = true;
            }
        }

        public void DisplayQuestion(string questionText)
        {
            // Clear previous controls
            questionPanel.Controls.Clear();

            // Create a new Label
            Label questionLabel = new Label
            {
                Text = questionText,
                AutoSize = false,  // Allow manual size adjustment
                ForeColor = Color.White,  // Set text color
                Font = new Font("Arial", 14, FontStyle.Bold),  // Set font size and style
                TextAlign = ContentAlignment.MiddleCenter,  // Center text within the label
                BackColor = Color.Transparent,  // Ensure background does not affect the panel
            };

            // Set label size to match panel width with some padding
            questionLabel.Size = new Size(questionPanel.Width - 20, 60);

            // Position label in the center of the panel
            questionLabel.Location = new Point(
                (questionPanel.Width - questionLabel.Width) / 2,
                (questionPanel.Height - questionLabel.Height) / 2
            );

            // Add the label to the panel
            questionPanel.Controls.Add(questionLabel);
        }

        private void DisplayAnswerOptions(string questionType)
        {
            // Clear existing controls
            surveySplitContainer.Panel2.Controls.Clear();
            surveySplitContainer.Panel2.Controls.Add(suivantButton);
            surveySplitContainer.Panel2.Controls.Add(translateButton);
            surveySplitContainer.Panel2.Controls.Add(progressBar);

            if (questionType == "yes_no")
            {
                yesCheckBox = new CheckBox
                {
                    Text = "Yes",
                    AutoSize = true,
                    Location = new Point(300, 160)
                };

                noCheckBox = new CheckBox
                {
                    Text = "No",
                    AutoSize = true,
                    Location = new Point(650, 160)
                };

                // Ensure only one can be checked
                yesCheckBox.CheckedChanged += (s, e) => { if (yesCheckBox.Checked) noCheckBox.Checked = false; };
                noCheckBox.CheckedChanged += (s, e) => { if (noCheckBox.Checked) yesCheckBox.Checked = false; };

                surveySplitContainer.Panel2.Controls.Add(yesCheckBox);
                surveySplitContainer.Panel2.Controls.Add(noCheckBox);
            }
            else if (questionType == "text")
            {
                textBoxAnswer = new System.Windows.Forms.TextBox
                {
                    Width = surveySplitContainer.Panel2.Width - 40,
                    Height = surveySplitContainer.Panel2.Height - 200,
                    Location = new Point(20, 90),
                    Multiline = true,
                    ScrollBars = ScrollBars.Vertical
                };

                surveySplitContainer.Panel2.Controls.Add(textBoxAnswer);
            }
            else if (questionType == "scale")
            {
                scaleCheckBoxes.Clear();  // Clear previous checkboxes
                int totalCheckBoxes = 10;
                int checkBoxWidth = 40;
                int checkBoxHeight = 40;
                int spacing = 50;
                int startX = (surveySplitContainer.Panel2.Width / 2) - ((totalCheckBoxes * spacing) / 2) - 15;
                int yPos = surveySplitContainer.Panel2.Height / 2 - 20;

                for (int i = 1; i <= totalCheckBoxes; i++)
                {
                    CheckBox scaleCheckBox = new CheckBox
                    {
                        Text = i.ToString(),
                        AutoSize = false,
                        Size = new Size(checkBoxWidth, checkBoxHeight),
                        Location = new Point(startX + (i - 1) * spacing, yPos),
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    // Ensure only one can be checked
                    scaleCheckBox.CheckedChanged += (s, e) =>
                    {
                        if (scaleCheckBox.Checked)
                        {
                            foreach (CheckBox cb in scaleCheckBoxes)
                            {
                                if (cb != scaleCheckBox) cb.Checked = false;
                            }
                        }
                    };

                    scaleCheckBoxes.Add(scaleCheckBox);
                    surveySplitContainer.Panel2.Controls.Add(scaleCheckBox);
                }
            }
        }

        private bool AddAnswer()
        {
            string response = "";

            if (nextQuestion.QuestionType == "yes_no")
            {
                if (yesCheckBox.Checked)
                    response = "Yes";
                else if (noCheckBox.Checked)
                    response = "No";
            }
            else if (nextQuestion.QuestionType == "text")
            {
                if (!string.IsNullOrWhiteSpace(textBoxAnswer.Text))
                    response = textBoxAnswer.Text;
            }
            else if (nextQuestion.QuestionType == "scale")
            {
                CheckBox selectedScale = scaleCheckBoxes.FirstOrDefault(cb => cb.Checked);
                if (selectedScale != null)
                    response = selectedScale.Text;
            }
            //MessageBox.Show("Response captured: " + response, "Debug");

            if (response != "")
            {
                Response res = new Response(response);
                studentController.CurrentStudent.Responses.Add(res);
                return true;
            }
            else { return false; }
        }

        private void suivantButton_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            if (btn != null)
            {
                btn.BackColor = Color.Green; // Darker shade on hover
            }
        }

        private void suivantButton_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            if (btn != null)
            {
                btn.BackColor = Color.Lime; // Reset to original color
            }
        }

        private void suivantButton_MouseDown(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            if (btn != null)
            {
                btn.BackColor = Color.DarkGreen; // Click effect
            }
        }

        private void suivantButton_MouseUp(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            if (btn != null)
            {
                btn.BackColor = Color.Green; // Return to hover color after click
            }
        }

    }
}
