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

            foreach (DataGridViewRow row in ProductsDataGridView.SelectedRows)
            {
                string manu = row.Cells[2].Value.ToString();
                string model = row.Cells[3].Value.ToString();
                string cost = row.Cells[1].Value.ToString();

                SelectionTextBox.Text = manu + " " + model + "priced at: $" + Convert.ToString(cost);
            }

            
        }
    }
}
