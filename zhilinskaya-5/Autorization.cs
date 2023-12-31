﻿using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zhilinskaya_5
{
    public partial class Autorization : Form
    {
        private string captcha;

        public Autorization()
        {
            InitializeComponent();
        }

        private void GenerateCaptcha()
        {
            captcha = GenerateRandomString(4);

            // Создание изображения для фона
            Bitmap bitmap = new Bitmap(pictureCapcha.Width, pictureCapcha.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                // Наложение графического шума (случайные линии и круги)
                Random random = new Random();
                for (int i = 0; i < 20; i++)
                {
                    int x1 = random.Next(bitmap.Width);
                    int y1 = random.Next(bitmap.Height);
                    int x2 = random.Next(bitmap.Width);
                    int y2 = random.Next(bitmap.Height);
                    graphics.DrawLine(new Pen(Color.Black), x1, y1, x2, y2);
                    graphics.DrawEllipse(new Pen(Color.DarkBlue), x1, y1, 8, 8);
                }

                // Наложение случайных символов на изображение
                Font font = new Font("Arial", 24, FontStyle.Bold);
                for (int i = 0; i < captcha.Length; i++)
                {
                    Brush brush = new SolidBrush(Color.DarkGray);
                    PointF point = new PointF(i * 30 + 10, random.Next(5, 20));
                    graphics.DrawString(captcha[i].ToString(), font, brush, point);
                }
            }

            // Отображение изображения в PictureBox
            pictureCapcha.Image = bitmap;
        }

        private string GenerateRandomString(int length)
        {
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new Izdat())
            {
                if (captcha != null && captcha != textCapha.Text)
                {
                    GenerateCaptcha();
                    MessageBox.Show("Неверная капча!");
                    return;
                }
                var user = db.customers.FirstOrDefault(x => x.customer_login == textBoxLogin.Text && x.customer_password == textBoxPassword.Text);
                if (user == null)
                {
                    pictureCapcha.Visible = true;
                    GenerateCaptcha();
                    textCapha.Visible = true;
                    pictureIcon.Visible = false;
                    MessageBox.Show("Пользователь с таким логином и паролем не обнаружен");
                    return;
                }
                UserState.Id = user.customer_id;
                UserState.Name = user.customer_name;
                UserState.Contact = user.contact;
                UserState.Address = user.address;
                UserState.Telephone = user.phone;
            }

            Hide();
            var main = new MainForm();
            main.ShowDialog();
            Show();
        }
    }
}
