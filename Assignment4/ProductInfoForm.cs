using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4/// <summary>
/// App Name - Movie Bonanza
/// Author - Balpreet Punia
/// Student Id - 200335082
/// Creation Date - 2017-03-05
/// Description - This app lets user place an order and buy a computer.
/// </summary>
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            loadInfo();
        }

        public void loadInfo()
        {
            ProductTextBox.Text = Program.products.productID.ToString();
            ConditionTextBox.Text = Program.products.condition;
            CostTextBox.Text = Program.products.cost.ToString();
            PlatformTextBox.Text = Program.products.platform;
            OSTextBox.Text= Program.products.OS;
            ManufacturerTextBox.Text= Program.products.manufacturer;
            ModelTextBox.Text= Program.products.model;
            MemoryTextBox.Text = Program.products.RAM_size;
            LcdTextBox.Text = Program.products.screensize;
            HddTextBox.Text = Program.products.HDD_size;
            BrandTextBox.Text = Program.products.CPU_brand;
            CpuNumberTextBox.Text = Program.products.CPU_number;
            GpuTypeTextBox.Text = Program.products.GPU_Type;
            CpuTypeTextBox.Text = Program.products.CPU_type;
            CpuSpeedTextBox.Text = Program.products.CPU_speed;
            WebCamTextBox.Text = Program.products.webcam;

        }

       
        private void SelectAnotherButton_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.ShowDialog();
            this.Hide();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelButton_Click(sender, e);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectAnotherButton_Click(sender, e);
        }
    }
}
