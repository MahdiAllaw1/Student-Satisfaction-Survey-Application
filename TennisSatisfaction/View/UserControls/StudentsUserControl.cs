using System;
using System.Data;
using System.Windows.Forms;
using TennisSatisfactionSurveySystem;

namespace TennisSatisfaction.View.UserControls
{
    public partial class StudentsUserControl : UserControl
    {
        private MySQLController sqlController;
        private DataGridView dataGridView;
        private TextBox nameTextBox;
        private ComboBox universityComboBox, courseTimeComboBox, genderComboBox, questionComboBox;
        private Button confirmButton;

        public StudentsUserControl()
        {
            InitializeComponent();
            sqlController = new MySQLController();
            InitializeDataGrid();
            InitializeControls();
        }

        private void InitializeDataGrid()
        {
            // Initialize DataGridView at (110, 70)
            dataGridView = new DataGridView
            {
                Location = new System.Drawing.Point(20, 80),
                Size = new System.Drawing.Size(760, 350),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.WhiteSmoke
            };
            splitContainer1.Panel2.Controls.Add(dataGridView);
        }

        private void InitializeControls()
        {
            // Initialize TextBox (for name) and ComboBoxes but keep them hidden
            nameTextBox = new TextBox { Location = new System.Drawing.Point(200, 20), Width = 400, Visible = false };
            universityComboBox = new ComboBox { Location = new System.Drawing.Point(200, 20), Width = 400, Visible = false };
            courseTimeComboBox = new ComboBox { Location = new System.Drawing.Point(200, 20), Width = 400, Visible = false };
            genderComboBox = new ComboBox { Location = new System.Drawing.Point(200, 20), Width = 400, Visible = false, DropDownStyle = ComboBoxStyle.DropDownList };
            questionComboBox = new ComboBox { Location = new System.Drawing.Point(200, 20), Width = 400, Visible = false };

            // Initialize Confirm Button (common for all)
            confirmButton = new Button
            {
                Location = new System.Drawing.Point(365, 45),
                Size = new System.Drawing.Size(75, 30),
                Text = "Confirm",
                BackColor = Color.Yellow,
                ForeColor = Color.Green,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            confirmButton.Click += ConfirmButton_Click;

            // Add controls to Panel2
            splitContainer1.Panel2.Controls.Add(nameTextBox);
            splitContainer1.Panel2.Controls.Add(universityComboBox);
            splitContainer1.Panel2.Controls.Add(courseTimeComboBox);
            splitContainer1.Panel2.Controls.Add(genderComboBox);
            splitContainer1.Panel2.Controls.Add(questionComboBox);
            splitContainer1.Panel2.Controls.Add(confirmButton);

            // Load ComboBox values
            LoadComboBoxValues();
        }

        private void ShowControl(Control control)
        {
            // Hide all controls before showing the required one
            nameTextBox.Visible = false;
            universityComboBox.Visible = false;
            courseTimeComboBox.Visible = false;
            genderComboBox.Visible = false;
            questionComboBox.Visible = false;
            confirmButton.Visible = false;

            // Show the selected control and Confirm button
            control.Visible = true;
            confirmButton.Visible = true;
        }

        private void LoadComboBoxValues()
        {
            universityComboBox.Items.Clear();
            courseTimeComboBox.Items.Clear();
            questionComboBox.Items.Clear();

            DataTable dtUniversities = sqlController.GetAllDistinctValues("university", "students");
            DataTable dtCourseTimes = sqlController.GetAllDistinctValues("course_time", "students");
            DataTable dtQuestions = sqlController.GetAllDistinctValues("question_text", "questions");

            foreach (DataRow row in dtUniversities.Rows) universityComboBox.Items.Add(row[0].ToString());
            foreach (DataRow row in dtCourseTimes.Rows) courseTimeComboBox.Items.Add(row[0].ToString());
            foreach (DataRow row in dtQuestions.Rows) questionComboBox.Items.Add(row[0].ToString());

            genderComboBox.Items.Clear();
            genderComboBox.Items.AddRange(new string[] { "Male", "Female", "Other" });
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Visible)
                LoadData(sqlController.SearchByName(nameTextBox.Text));
            else if (universityComboBox.Visible)
                LoadData(sqlController.SearchByUniversity(universityComboBox.Text));
            else if (courseTimeComboBox.Visible)
                LoadData(sqlController.SearchByCourseTime(courseTimeComboBox.Text));
            else if (genderComboBox.Visible)
                LoadData(sqlController.SearchByGender(genderComboBox.Text));
            else if (questionComboBox.Visible)
                LoadData(sqlController.SearchAnswersByQuestion(questionComboBox.Text));
        }

        private void LoadData(DataTable dt)
        {
            dataGridView.DataSource = dt;
        }

        private void searchByNameButton_Click(object sender, EventArgs e)
        {
            ShowControl(nameTextBox);
        }

        private void searchByUniversityButton_Click(object sender, EventArgs e)
        {
            ShowControl(universityComboBox);
        }

        private void searchByCourseTimeButton_Click(object sender, EventArgs e)
        {
            ShowControl(courseTimeComboBox);
        }

        private void searchByGenderButton_Click(object sender, EventArgs e)
        {
            ShowControl(genderComboBox);
        }

        private void searchByQuestionButton_Click(object sender, EventArgs e)
        {
            ShowControl(questionComboBox);
        }
    }
}
