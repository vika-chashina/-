using System;
using System.Windows.Forms;

namespace RoyalMotors
{
    public class ClientForm : Form
    {
        TextBox txtName, txtPhone, txtEmail;
        ComboBox cmbNeed;

        public ClientForm()
        {
            Ui.Style(this, "Royal Motors — Форма клиента");
            Ui.AddHeader(this, "Форма клиента");

            Controls.Add(Ui.Label("ФИО клиента:", 85, 110, 140, 28));
            txtName = Ui.TextBox(235, 110, 390, 28);
            Controls.Add(txtName);

            Controls.Add(Ui.Label("Телефон:", 85, 160, 140, 28));
            txtPhone = Ui.TextBox(235, 160, 390, 28);
            Controls.Add(txtPhone);

            Controls.Add(Ui.Label("Электронная почта:", 85, 210, 145, 28));
            txtEmail = Ui.TextBox(235, 210, 390, 28);
            Controls.Add(txtEmail);

            Controls.Add(Ui.Label("Интересует:", 85, 260, 140, 28));
            cmbNeed = new ComboBox();
            cmbNeed.Location = new System.Drawing.Point(235, 260);
            cmbNeed.Size = new System.Drawing.Size(390, 28);
            cmbNeed.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNeed.Items.AddRange(new object[] { "Покупка автомобиля", "Тест-драйв", "Консультация" });
            cmbNeed.SelectedIndex = 0;
            Controls.Add(cmbNeed);

            Button save = Ui.Button("Сохранить", 235, 325, 170, 45);
            save.Click += delegate
            {
                if (txtName.Text.Trim() == "")
                {
                    MessageBox.Show("Введите ФИО клиента.");
                    return;
                }
                MessageBox.Show("Данные клиента введены (демо-режим).");
            };
            Controls.Add(save);

            Button back = new Button();
            back.Text = "Назад";
            back.Location = new System.Drawing.Point(425, 325);
            back.Size = new System.Drawing.Size(200, 45);
            back.Click += delegate { Close(); };
            Controls.Add(back);
        }
    }
}
