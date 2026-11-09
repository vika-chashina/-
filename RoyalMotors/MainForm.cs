using System;
using System.Drawing;
using System.Windows.Forms;

namespace RoyalMotors
{
    public class MainForm : Form
    {
        private string userRole;

        public MainForm(string role)
        {
            userRole = role;
            Ui.Style(this, "Royal Motors — Главное меню");
            Ui.AddHeader(this, "ROYAL MOTORS");

            Label subtitle = Ui.Label("Автосалон премиальных автомобилей", 30, 78, 700, 35, 14);
            subtitle.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(subtitle);

            Label welcome = Ui.Label("Главное меню • Вы вошли как: " + userRole, 50, 130, 660, 30, 11);
            welcome.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(welcome);

            Button cars = Ui.Button("Автомобили", 220, 185, 320, 48);
            cars.Click += delegate { new CarsForm().ShowDialog(); };
            Controls.Add(cars);

            Button client = Ui.Button("Форма клиента", 220, 245, 320, 48);
            client.Click += delegate { new ClientForm().ShowDialog(); };
            Controls.Add(client);

            Button registration = Ui.Button("Регистрация", 220, 305, 320, 48);
            registration.Click += delegate { new RegistrationForm().ShowDialog(); };
            Controls.Add(registration);

            Button logout = new Button();
            logout.Text = "Выйти";
            logout.Location = new Point(300, 385);
            logout.Size = new Size(160, 40);
            logout.Click += delegate { Close(); };
            Controls.Add(logout);
        }
    }
}
