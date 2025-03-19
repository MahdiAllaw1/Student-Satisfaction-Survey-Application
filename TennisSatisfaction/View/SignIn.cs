using TennisSatisfaction.Controller;
using TennisSatisfaction.View;

namespace TennisSatisfaction
{
    public partial class SignIn : Form
    {
        private AdminController controller;
        public SignIn()
        {
            InitializeComponent();
            controller = new AdminController();
            this.AcceptButton = signInButton;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            controller = new AdminController(usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim());
            if (controller.SignIn() == true)
            {
                usernameTextBox.Clear();
                passwordTextBox.Clear();
                this.Hide();
                AdminPage nextForm = new AdminPage();
                nextForm.FormClosing += (s, args) => this.Show();
                nextForm.Show();
            }
        }
        }
    }
