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
    public partial class RegisterLoginForm : Form
    {
        DataController dataController = new DataController();
        UserController userController = new UserController();

        public RegisterLoginForm()
        {
            InitializeComponent();
            AutoSize = true;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Hide();
            loginForm.Show();
        }

        private void RegisterLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            string login = textBox.Text;
            if (userController.IsUserExists(login))
            {
                MessageBox.Show("Такой логин уже существует!");
            }
            else if (String.IsNullOrEmpty(login))
            {
                MessageBox.Show("Поле логина не может быть пустым!");
            }
            else
            {
                RegisterPasswordForm registerPasswordForm = new RegisterPasswordForm(login);
                registerPasswordForm.Show();
                Hide();
            }
        }
    }
}
