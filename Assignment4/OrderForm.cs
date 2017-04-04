using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    /// <summary>
    /// App Name - Movie Bonanza
    /// Author - Balpreet Punia
    /// Student Id - 200335082
    /// Creation Date - 2017-03-05
    /// Description - This app lets user place an order and buy a computer.
    /// </summary>
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            updatePrice();
        }

        private void updatePrice()
        {
            PriceTextBox.Text = Program.products.cost.ToString();
            TaxTextBox.Text = (Program.products.cost * 0.13).ToString();
            TotalTextBox.Text = (Program.products.cost + (Program.products.cost * 0.13)).ToString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.ShowDialog();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelButton_Click(sender, e);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackButton_Click(sender, e);
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order has been placed and will be delivered to you in 7-10 business days. Thank You.");
            Application.Exit();
        }
    }
}
