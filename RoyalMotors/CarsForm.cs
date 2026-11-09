using System;
using System.Drawing;
using System.Windows.Forms;

namespace RoyalMotors
{
    public class CarsForm : Form
    {
        ListBox list;
        Label details;

        public CarsForm()
        {
            Ui.Style(this, "Royal Motors — Автомобили");
            Ui.AddHeader(this, "Автомобили");

            list = new ListBox();
            list.Location = new Point(70, 105);
            list.Size = new Size(260, 245);
            list.Font = new Font("Arial", 12);
            list.Items.Add("BMW 5 Series");
            list.Items.Add("Mercedes-Benz E-Class");
            list.Items.Add("Audi A6");
            list.Items.Add("Porsche Cayenne");
            list.SelectedIndexChanged += ShowDetails;
            Controls.Add(list);

            details = Ui.Label("Выберите автомобиль из списка.", 370, 115, 300, 150, 12);
            details.BorderStyle = BorderStyle.FixedSingle;
            details.Padding = new Padding(10);
            Controls.Add(details);

            Button back = new Button();
            back.Text = "Назад";
            back.Location = new Point(370, 300);
            back.Size = new Size(180, 45);
            back.Click += delegate { Close(); };
            Controls.Add(back);
        }

        private void ShowDetails(object sender, EventArgs e)
        {
            if (list.SelectedItem == null) return;

            string car = list.SelectedItem.ToString();
            string price = "от 5 000 000 ₽";
            if (car == "BMW 5 Series") price = "от 6 000 000 ₽";
            if (car == "Mercedes-Benz E-Class") price = "от 7 000 000 ₽";
            if (car == "Audi A6") price = "от 5 500 000 ₽";
            if (car == "Porsche Cayenne") price = "от 12 000 000 ₽";

            details.Text = "Автомобиль:\r\n" + car + "\r\n\r\nЦена:\r\n" + price;
        }
    }
}
