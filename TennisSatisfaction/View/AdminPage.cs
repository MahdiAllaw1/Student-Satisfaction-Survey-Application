using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TennisSatisfaction.View.UserControls;

namespace TennisSatisfaction.View
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void questionsButton_Click(object sender, EventArgs e)
        {
            QuestionsUserControl questionsUserControl = new QuestionsUserControl();
            addUserControl(questionsUserControl);
        }

        private void studentsButton_Click(object sender, EventArgs e)
        {
            StudentsUserControl studentsUserControl = new StudentsUserControl();
            addUserControl(studentsUserControl);
        }

        private void RegisterStudentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentRegister nextForm = new StudentRegister();
            nextForm.FormClosing += (s, args) => this.Close();
            nextForm.Show();
        }
    }
}
