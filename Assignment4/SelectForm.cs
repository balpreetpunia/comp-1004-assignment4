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
{/// <summary>
/// App Name - Movie Bonanza
/// Author - Balpreet Punia
/// Student Id - 200335082
/// Creation Date - 2017-03-05
/// Description - This app lets user place an order and buy a computer.
/// </summary>
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productsDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.productsDataSet.products);

        }

        private void ProductsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            ProductsDataGridView.CurrentRow.Selected = true;

            string manu = ProductsDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            string model = ProductsDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            string cost = ProductsDataGridView.SelectedRows[0].Cells[1].Value.ToString();

            SelectionTextBox.Text = manu + " " + model + " priced at: $" + Convert.ToString(cost);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            savingProducts();

            this.Hide();
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.ShowDialog();
            

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void savingProducts()
        {
            Program.products.Audio_type = ProductsDataGridView.SelectedRows[0].Cells[21].Value.ToString();
            Program.products.condition = ProductsDataGridView.SelectedRows[0].Cells[14].Value.ToString();
            Program.products.cost = Convert.ToDouble(ProductsDataGridView.SelectedRows[0].Cells[1].Value);
            Program.products.CPU_brand = ProductsDataGridView.SelectedRows[0].Cells[10].Value.ToString();
            Program.products.CPU_Class = ProductsDataGridView.SelectedRows[0].Cells[9].Value.ToString();
            Program.products.CPU_number = ProductsDataGridView.SelectedRows[0].Cells[13].Value.ToString();
            Program.products.CPU_speed = ProductsDataGridView.SelectedRows[0].Cells[12].Value.ToString();
            Program.products.CPU_type = ProductsDataGridView.SelectedRows[0].Cells[11].Value.ToString();
            Program.products.depth = ProductsDataGridView.SelectedRows[0].Cells[26].Value.ToString();
            Program.products.displaytype = ProductsDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            Program.products.GPU_Type = ProductsDataGridView.SelectedRows[0].Cells[19].Value.ToString();
            Program.products.HDD_size = ProductsDataGridView.SelectedRows[0].Cells[17].Value.ToString();
            Program.products.HDD_speed = ProductsDataGridView.SelectedRows[0].Cells[18].Value.ToString();
            Program.products.height = ProductsDataGridView.SelectedRows[0].Cells[25].Value.ToString();
            Program.products.LAN = ProductsDataGridView.SelectedRows[0].Cells[22].Value.ToString();
            Program.products.manufacturer = ProductsDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Program.products.model = ProductsDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            Program.products.moust_type = ProductsDataGridView.SelectedRows[0].Cells[28].Value.ToString();
            Program.products.optical_drive = ProductsDataGridView.SelectedRows[0].Cells[20].Value.ToString();
            Program.products.OS = ProductsDataGridView.SelectedRows[0].Cells[15].Value.ToString();
            Program.products.platform = ProductsDataGridView.SelectedRows[0].Cells[16].Value.ToString();
            Program.products.power = ProductsDataGridView.SelectedRows[0].Cells[29].Value.ToString();
            Program.products.productID = Convert.ToInt16(ProductsDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            Program.products.RAM_size = ProductsDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            Program.products.RAM_type = ProductsDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            Program.products.resolution = ProductsDataGridView.SelectedRows[0].Cells[8].Value.ToString();
            Program.products.screensize = ProductsDataGridView.SelectedRows[0].Cells[7].Value.ToString();
            Program.products.webcam = ProductsDataGridView.SelectedRows[0].Cells[30].Value.ToString();
            Program.products.weight = ProductsDataGridView.SelectedRows[0].Cells[27].Value.ToString();
            Program.products.width = ProductsDataGridView.SelectedRows[0].Cells[24].Value.ToString();
            Program.products.WIFI = ProductsDataGridView.SelectedRows[0].Cells[23].Value.ToString();
        }
    }
}
