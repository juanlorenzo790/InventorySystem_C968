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
    public partial class ModifyProduct : Form
    {
        private Product _productToModify;
        public ModifyProduct(Product selectedProduct)

        {

            InitializeComponent();
            _productToModify = selectedProduct;
            modiProductsTxtBoxid.Text = _productToModify.ProductID.ToString();
            modiProductsTxtBoxName.Text = _productToModify.Name;
            modiProductsTxtBoxInventory.Text = _productToModify.InStock.ToString();
            modiProductsTxtBoxPriCos.Text = _productToModify.Price.ToString();
            modiProductsTxtBoxMax.Text = _productToModify.Max.ToString();
            modiProductsTxtBoxMin.Text = _productToModify.Min.ToString();

            modiProductsCandDataGrid.DataSource = Inventory.AllParts;
            modiProductsAssoDataGrid.DataSource = _productToModify.AssociatedParts;

            FormatGrid(modiProductsCandDataGrid);
            FormatGrid(modiProductsAssoDataGrid);
        }
        private void FormatGrid(DataGridView dgv)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void modiProductsAddButton_Click(object sender, EventArgs e)
        {
            if (modiProductsCandDataGrid.CurrentRow == null || !modiProductsCandDataGrid.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part from the top list to add.");
                return;
            }

            Part selectedPart = (Part)modiProductsCandDataGrid.CurrentRow.DataBoundItem;

            _productToModify.AddAssociatedPart(selectedPart);
        }

        private void modiProductsDeleteButton_Click(object sender, EventArgs e)
        {
            if (modiProductsAssoDataGrid.CurrentRow == null || !modiProductsAssoDataGrid.CurrentRow.Selected)
            {
                MessageBox.Show("Please select an associated part to remove.");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to remove this associated part?", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Part selectedPart = (Part)modiProductsAssoDataGrid.CurrentRow.DataBoundItem;
                _productToModify.RemoveAssociatedPart(selectedPart.PartID);
            }
        }

        private void modiProductsSearchButton_Click(object sender, EventArgs e)
        {
            string searchText = modiProductsTextBox.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                modiProductsCandDataGrid.DataSource = Inventory.AllParts;
                return;
            }
            if (int.TryParse(searchText, out int partId))
            {
                Part foundPart = Inventory.LookupPart(partId);
                if (foundPart != null)
                {
                    modiProductsCandDataGrid.ClearSelection();
                    foreach (DataGridViewRow row in modiProductsCandDataGrid.Rows)
                    {
                        if ((int)row.Cells["PartID"].Value == partId)
                        {
                            row.Selected = true;
                            return;
                        }
                    }
                }
            }

            BindingList<Part> filteredParts = Inventory.LookupPart(searchText);
            modiProductsCandDataGrid.DataSource = filteredParts;
        }

        private void modiProductsSaveButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(modiProductsTxtBoxInventory.Text, out int inventory) ||
        !decimal.TryParse(modiProductsTxtBoxPriCos.Text, out decimal price) ||
        !int.TryParse(modiProductsTxtBoxMax.Text, out int max) ||
        !int.TryParse(modiProductsTxtBoxMin.Text, out int min))
            {
                MessageBox.Show("Inventory, Price, Max, and Min must be numeric.");
                return;
            }
            if (min > max)
            {
                MessageBox.Show("Min cannot be greater than Max.");
                return;
            }
            if (inventory < min || inventory > max)
            {
                MessageBox.Show("Inventory must be between Min and Max.");
                return;
            }
            _productToModify.Name = modiProductsTxtBoxName.Text;
            _productToModify.InStock = inventory;
            _productToModify.Price = price;
            _productToModify.Max = max;
            _productToModify.Min = min;

            Inventory.UpdateProduct(_productToModify.ProductID, _productToModify);

            this.Close();
        }

        private void modiProductsCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
