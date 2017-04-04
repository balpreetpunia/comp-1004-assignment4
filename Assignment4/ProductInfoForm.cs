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
    }
}
