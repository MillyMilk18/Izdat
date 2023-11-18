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

namespace zhilinskaya_5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            username.Text = UserState.Name;
            using (var db = new Izdat())
            {
                dataGridView1.DataSource = db.orders.Where(x => x.customer_id == UserState.Id).ToList();
                dataGridView1.Columns["customer_id"].Visible = false;
                dataGridView1.Columns["books"].Visible = false;
                dataGridView1.Columns["customers"].Visible = false;

                dataGridView1.Columns["receipt_date"].HeaderText = "Дата чека";
                dataGridView1.Columns["fulfillment_date"].HeaderText = "Дата выполнения";
                dataGridView1.Columns["copies_number"].HeaderText = "Номер копии";
                dataGridView1.Columns["order_number"].HeaderText = "Номер покупки";
                dataGridView1.Columns["cipher_of_book"].HeaderText = "Шифр книги";
            }
        }

        private void linkFIO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkFIO.Text == "Показать")
                linkFIO.Text = UserState.Contact;
            else
                linkFIO.Text = "Показать";
        }

        private void linkAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkAddress.Text == "Показать")
                linkAddress.Text = UserState.Address;
            else
                linkAddress.Text = "Показать";
        }

        private void linkPhone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkPhone.Text == "Показать")
                linkPhone.Text = UserState.Telephone;
            else
                linkPhone.Text = "Показать";
        }

        private void newOreder_Click(object sender, EventArgs e)
        {
            Hide();
            var newOrder = new NewOrder();
            newOrder.ShowDialog();
            Dispose();
        }
    }
}
