using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TennisSatisfaction.Controller;
using TennisSatisfaction.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TennisSatisfaction.View
{
    public partial class StudentRegister : Form
    {
        private StudentController controller;

        // Default constructor (when opening the form normally)
        public StudentRegister()
        {
            InitializeComponent();
            this.AcceptButton = nextButton;
            controller = new StudentController(); // New instance
            checkMale.CheckedChanged += (s, e) =>
            {
                if (checkMale.Checked)
                {
                    checkFemale.Checked = false;
                    checkOther.Checked = false;
                }
            };

            checkFemale.CheckedChanged += (s, e) =>
            {
                if (checkFemale.Checked)
                {
                    checkMale.Checked = false;
                    checkOther.Checked = false;
                }
            };

            checkOther.CheckedChanged += (s, e) =>
            {
                if (checkOther.Checked)
                {
                    checkMale.Checked = false;
                    checkFemale.Checked = false;
                }
            };
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get full name from the textboxes
                string fullName = firstnameTextBox.Text.Trim() + " " + lastnameTextBox.Text.Trim();

                // Determine selected gender
                string gender = "";
                if (checkMale.Checked) gender = "Male";
                else if (checkFemale.Checked) gender = "Female";
                else if (checkOther.Checked) gender = "Other";

                // Get email
                string email = emailTextBox.Text.Trim();

                // Get university selection
                string university = universityComboBox.SelectedItem?.ToString() ?? "";

                // Get course time selection
                string courseTime = courseTimeComboBox.SelectedItem?.ToString() ?? "";

                // Validate inputs (basic validation)
                if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(gender) ||
                    string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(university) ||
                    string.IsNullOrWhiteSpace(courseTime))
                {
                    MessageBox.Show("Please fill in all fields before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create a new Student instance
                Student newStudent = new Student(fullName, gender, email, university, courseTime);

                // Add student to the temporary list
                controller.AddStudent(newStudent);
                //controller.SaveAllStudentsToDatabase();

                //MessageBox.Show("Student added to the list!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the form inputs for the next student
                firstnameTextBox.Clear();
                lastnameTextBox.Clear();
                checkMale.Checked = checkFemale.Checked = checkOther.Checked = false;
                emailTextBox.Clear();
                universityComboBox.SelectedIndex = -1;
                courseTimeComboBox.SelectedIndex = -1;

                // Proceed to the next step (e.g., open another form)
                this.Hide();
                Survey nextForm = new Survey(controller);
                nextForm.FormClosing += (s, args) => this.Show();
                nextForm.Show();

                /*Survey nextForm = new Survey(controller);
                nextForm.Show();
                this.Hide();*/
                //MessageBox.Show(newStudent.Name, "Welcome");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void firstnameTextBox_Enter(object sender, EventArgs e)
        {
            if (firstnameTextBox.Text == "First name (prenom)")
            {
                firstnameTextBox.Text = "";
                firstnameTextBox.ForeColor = Color.Black; // Change text color to normal
            }
        }

        private void lastnameTextBox_Enter(object sender, EventArgs e)
        {
            if (lastnameTextBox.Text == "Last name (nom)")
            {
                lastnameTextBox.Text = "";
                lastnameTextBox.ForeColor = Color.Black; // Change text color to normal
            }
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "@example.com")
            {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.Black; // Change text color to normal
            }
        }
    }
}
