using Kursach_3_Sem.Controller;
using Kursach_3_Sem.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class RegisterPasswordForm : Form
    {
        DataController dataController = new DataController();
        UserController userController = new UserController();

        string login;

        public RegisterPasswordForm(string login)
        {
            InitializeComponent();
            AutoSize = true;
            StartPosition = FormStartPosition.CenterScreen;
            this.login = login;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Hide();
            loginForm.Show();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            string password = textBox.Text;
            if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Поле пароля не может быть пустым!");
            }
            else
            {
                userController.AddUser(login, password);
                MainMenuForm mainMenuForm = new MainMenuForm(new UserController(login,password));
                mainMenuForm.Show();
                Hide();
            }
        }

        private void RegisterPasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
