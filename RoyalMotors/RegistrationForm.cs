using System;
using System.Windows.Forms;

namespace RoyalMotors
{
    public class RegistrationForm : Form
    {
        TextBox txtName, txtLogin, txtPassword, txtPhone;

        public RegistrationForm()
        {
            Ui.Style(this, "Royal Motors — Регистрация");
            Ui.AddHeader(this, "Регистрация клиента");

            Controls.Add(Ui.Label("ФИО:", 90, 105, 120, 28));
            txtName = Ui.TextBox(220, 105, 390, 28);
            Controls.Add(txtName);

            Controls.Add(Ui.Label("Логин:", 90, 155, 120, 28));
            txtLogin = Ui.TextBox(220, 155, 390, 28);
            Controls.Add(txtLogin);

            Controls.Add(Ui.Label("Пароль:", 90, 205, 120, 28));
            txtPassword = Ui.TextBox(220, 205, 390, 28, true);
            Controls.Add(txtPassword);

            Controls.Add(Ui.Label("Телефон:", 90, 255, 120, 28));
            txtPhone = Ui.TextBox(220, 255, 390, 28);
            Controls.Add(txtPhone);

            Button save = Ui.Button("Зарегистрироваться", 220, 315, 240, 45);
            save.Click += Save;
            Controls.Add(save);

            Button close = new Button();
            close.Text = "Назад";
            close.Location = new System.Drawing.Point(475, 315);
            close.Size = new System.Drawing.Size(135, 45);
            close.Click += delegate { Close(); };
            Controls.Add(close);
        }

        private void Save(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || txtLogin.Text.Trim() == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Заполните ФИО, логин и пароль.");
                return;
            }

            MessageBox.Show("Форма заполнена. Для настоящей регистрации нужно подключить базу данных.",
                "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
