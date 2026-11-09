using System;
using System.Drawing;
using System.Windows.Forms;

namespace RoyalMotors
{
    public static class Ui
    {
        public static void Style(Form form, string title)
        {
            form.Text = title;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ClientSize = new Size(760, 480);
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.BackColor = Color.WhiteSmoke;
            form.Font = new Font("Arial", 11);
        }

        public static Label Label(string text, int x, int y, int w, int h, int size = 11, bool bold = false)
        {
            Label label = new Label();
            label.Text = text;
            label.Location = new Point(x, y);
            label.Size = new Size(w, h);
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Font = new Font("Arial", size, bold ? FontStyle.Bold : FontStyle.Regular);
            return label;
        }

        public static Button Button(string text, int x, int y, int w, int h)
        {
            Button button = new Button();
            button.Text = text;
            button.Location = new Point(x, y);
            button.Size = new Size(w, h);
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.FromArgb(218, 184, 105);
            return button;
        }

        public static TextBox TextBox(int x, int y, int w, int h, bool password = false)
        {
            TextBox box = new TextBox();
            box.Location = new Point(x, y);
            box.Size = new Size(w, h);
            box.UseSystemPasswordChar = password;
            return box;
        }

        public static void AddHeader(Form form, string title)
        {
            Label header = Label(title, 25, 20, 710, 55, 24, true);
            header.TextAlign = ContentAlignment.MiddleCenter;
            form.Controls.Add(header);
        }
    }
}
