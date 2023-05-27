using informationSystem.Forms;
using System;
using System.Windows.Forms;
using informationSystem.Entities;
namespace informationSystem
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent(); 

        }


        private void passwordShowButton_Click(object sender, EventArgs e)
        {
            if(passwordBox.UseSystemPasswordChar == true)
            {
                passwordBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordBox.UseSystemPasswordChar = true;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            connectToSQL method = new connectToSQL();
            using (var ctx = new TradeEntities())
            {
                User user = new User();
                user.UserLogin = loginBox.Text;
                user.UserPassword = passwordBox.Text;
                user.UserName = method.getFromDBItem<string>($"SELECT UserName FROM [User] WHERE UserLogin='{loginBox.Text}' AND UserPassword='{passwordBox.Text}'", "UserName");
                user.UserSurname = method.getFromDBItem<string>($"SELECT UserSurname FROM [User] WHERE UserLogin='{loginBox.Text}' AND UserPassword='{passwordBox.Text}'", "UserSurname");
                fullName.Text = $"{user.UserName} {user.UserSurname}";



                int typeUser = method.getFromDBItem<int>($"SELECT UserRole FROM [User] WHERE UserLogin='{user.UserLogin}' AND UserPassword='{user.UserPassword}'", "UserRole");
                string UserName = method.getFromDBItem<string>($"SELECT UserName FROM [User] WHERE UserLogin='{user.UserLogin}' AND UserPassword='{user.UserPassword}'", "UserName");
                string UserSurname = method.getFromDBItem<string>($"SELECT UserSurname FROM [User] WHERE UserLogin='{user.UserLogin}' AND UserPassword='{user.UserPassword}'", "UserSurname");

                if (typeUser != 0)
                {
                    if (captchaTextBox.Text == "AGQTF5")
                    {

                        MessageBox.Show("Вы вошли в систему", "Вход выполнен!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        testForm testForm = new testForm();
                        testForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Не верно введена капча!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Не верный логин/пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            fullName.Hide();
        }
    }
}
