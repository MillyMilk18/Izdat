using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace zhilinskaya_5
{
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
            using (var db = new Izdat())
            {
                comboBox1.DisplayMember = "title";
                comboBox1.ValueMember = "cipher";
                comboBox1.DataSource = db.books.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var quantity = (int)numericUpDown1.Value;
            if (quantity <= 0)
            {
                MessageBox.Show("Введите корректное количество");
                return;
            }
            using (var db = new Izdat())
            {
                var order = new orders
                {
                    cipher_of_book = (int)comboBox1.SelectedValue,
                    customer_id = UserState.Id,
                    receipt_date = DateTime.Now,
                    copies_number = quantity
                };
                db.orders.Add(order);
                db.SaveChanges();
                MessageBox.Show("Заказ успешно создан");
            }
        }

        private void profil_Click(object sender, EventArgs e)
        {
            Hide();
            var mainForm = new MainForm();
            mainForm.ShowDialog();
            Show();
            Dispose();
        }
    }
}
