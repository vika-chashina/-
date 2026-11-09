using System;
using System.Drawing;
using System.Windows.Forms;

namespace RoyalMotors
{
    public class LoginForm : Form
    {
        TextBox txtLogin;
        TextBox txtPassword;

        public LoginForm()
        {
            Ui.Style(this, "Royal Motors — Вход в систему");
            Ui.AddHeader(this, "ROYAL MOTORS");
            Label subtitle = Ui.Label("Авторизация", 30, 80, 700, 35, 14);
            subtitle.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(subtitle);

            Controls.Add(Ui.Label("Логин:", 105, 155, 110, 30));
            txtLogin = Ui.TextBox(230, 155, 400, 30);
            Controls.Add(txtLogin);

            Controls.Add(Ui.Label("Пароль:", 105, 215, 110, 30));
            txtPassword = Ui.TextBox(230, 215, 400, 30, true);
            Controls.Add(txtPassword);

            Button btnLogin = Ui.Button("Войти", 230, 285, 170, 45);
            btnLogin.Click += Login;
            Controls.Add(btnLogin);

            Button btnRegister = Ui.Button("Регистрация", 420, 285, 210, 45);
            btnRegister.Click += delegate { new RegistrationForm().ShowDialog(); };
            Controls.Add(btnRegister);

            Label note = Ui.Label("Тестовый вход: client / client, manager / manager", 40, 365, 680, 30, 10);
            note.TextAlign = ContentAlignment.MiddleCenter;
            note.ForeColor = Color.DimGray;
            Controls.Add(note);
        }

        private void Login(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;

            if ((login == "client" && password == "client") ||
                (login == "manager" && password == "manager"))
            {
                Hide();
                MainForm main = new MainForm(login == "manager" ? "Менеджер" : "Клиент");
                main.FormClosed += delegate { Close(); };
                main.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
