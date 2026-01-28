using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class addProductWindow : Form
    {
        private Product tempProduct = new Product();
        public addProductWindow()
        {
            InitializeComponent();
            int maxId = 0;
            foreach (Product prod in Inventory.Products)
            {
                if (prod.ProductID > maxId) maxId = prod.ProductID;
            }
            addProductsTxtBoxid.Text = (maxId + 1).ToString();

            addProductsCandDataGrid.DataSource = Inventory.AllParts;
            addProductsAssoDataGrid.DataSource = tempProduct.AssociatedParts;

            FormatGrid(addProductsCandDataGrid);
            FormatGrid(addProductsAssoDataGrid);
        }

        private void FormatGrid(DataGridView dgv)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void addProductsAddButton_Click(object sender, EventArgs e)
        {
            if (addProductsCandDataGrid.CurrentRow == null)
            {
                MessageBox.Show("Please select a part to add.");
                return;
            }

            Part selectedPart = (Part)addProductsCandDataGrid.CurrentRow.DataBoundItem;
            tempProduct.AddAssociatedPart(selectedPart);
            addProductsAssoDataGrid.DataSource = null;
            addProductsAssoDataGrid.DataSource = tempProduct.AssociatedParts;
            FormatGrid(addProductsAssoDataGrid);
        }

        private void addProductsDeleteButton_Click(object sender, EventArgs e)
        {
            if (addProductsAssoDataGrid.CurrentRow == null)
            {
                MessageBox.Show("Please select an associated part to remove.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to remove this part?", "Confirm Remove", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Part selectedPart = (Part)addProductsAssoDataGrid.CurrentRow.DataBoundItem;
                tempProduct.RemoveAssociatedPart(selectedPart.PartID);
            }
        }

        private void addProductsSearchButton_Click(object sender, EventArgs e)
        {
            string searchText = addProductsTextBox.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                addProductsCandDataGrid.DataSource = Inventory.AllParts;
                return;
            }

            BindingList<Part> filteredParts = Inventory.LookupPart(searchText);
            addProductsCandDataGrid.DataSource = filteredParts;

            if (filteredParts.Count == 0) MessageBox.Show("No parts found.");
        }

        private void addProductsSaveButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(addProductsTxtBoxInventory.Text, out int inv) ||
                !decimal.TryParse(addProductsTxtBoxPriCos.Text, out decimal price) ||
                !int.TryParse(addProductsTxtBoxMax.Text, out int max) ||
                !int.TryParse(addProductsTxtBoxMin.Text, out int min))
            {
                MessageBox.Show("Ensure Items in inventory, Price, and inventory Max and Min are numeric values.");
                return;
            }
            if (min>max)
            {
                MessageBox.Show("Min cannot be greater than Max");
                return;
            }
            if (inv < min || inv > max)
            {
                MessageBox.Show("Inventory must be between Min and Max Items");
                return;
            }
            tempProduct.ProductID = int.Parse(addProductsTxtBoxInventory.Text);
            tempProduct.Name = addProductsTxtBoxName.Text;
            tempProduct.InStock = inv;
            tempProduct.Price = price;
            tempProduct.Max = max;
            tempProduct.Min = min;
            //Save to inventory
            Inventory.AddProduct(tempProduct);
            this.Close();
        }

        private void addProductsCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
