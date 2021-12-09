using Kursach_3_Sem.Controller;
using Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach_3_Sem.view
{
    public partial class LoginForm : Form
    {
        DataController dataController = new DataController();
        UserController userController = new UserController();

        public LoginForm()
        {
            InitializeComponent();
            AutoSize = true;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            dataController.Read();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            if (userController.IsRightUser(login,password))
            {
                MainMenuForm mainMenuForm = new MainMenuForm(new UserController(login, password));
                mainMenuForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Неверно введен логин или пароль!");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterLoginForm registerLoginForm = new RegisterLoginForm();
            registerLoginForm.Show();
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            dataController.Save();
            Application.Exit();
        }
    }
}
