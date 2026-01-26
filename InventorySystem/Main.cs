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
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
            partsDataGrid.DataSource = Inventory.AllParts;
            productsDataGrid.DataSource = Inventory.Products;

            FormatGrid(partsDataGrid);
            FormatGrid(productsDataGrid);
        }
        private void FormatGrid(DataGridView dgv)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //checks for ID if no valid defaults for name
        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            string searchText = partsTextBox.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                partsDataGrid.DataSource = Inventory.AllParts;
                return;
            }
            if (int.TryParse(searchText, out int partId))
            {
                Part foundPart = Inventory.LookupPart(partId);
                if (foundPart != null)
                {
                    foreach (DataGridViewRow row in partsDataGrid.Rows)
                    {
                        if ((int)row.Cells["PartID"].Value == partId)
                        {
                            partsDataGrid.ClearSelection();
                            row.Selected = true;
                            return;
                        }
                    }
                }
            }
            BindingList<Part> filteredParts = Inventory.LookupPart(searchText);
            partsDataGrid.DataSource = filteredParts;

            if (filteredParts.Count == 0)
            {
                MessageBox.Show("No parts found with that criteria.");
            }
        }

        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            string searchText = productsTextBox.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                productsDataGrid.DataSource = Inventory.Products;
                return;
            }
            if (int.TryParse(searchText, out int productId))
            {
                Product foundProduct = Inventory.LookupProduct(productId);
                if (foundProduct != null)
                {
                    foreach (DataGridViewRow row in productsDataGrid.Rows)
                    {
                        if ((int)row.Cells["ProductID"].Value == productId)
                        {
                            productsDataGrid.ClearSelection();
                            row.Selected = true;
                            return;
                        }
                    }
                }
            }
            BindingList<Product> filteredProducts = Inventory.LookupProduct(searchText);
            productsDataGrid.DataSource = filteredProducts;

            if (filteredProducts.Count == 0)
            {
                MessageBox.Show("No products found matching the search criteria.");
            }
        }

        private void mainPageExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void partsAddButton_Click(object sender, EventArgs e)
        {
            AddingPartPage addForm = new AddingPartPage();
            addForm.ShowDialog();
        }

        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            if (partsDataGrid.CurrentRow != null)
            {
                Part selectedPart = (Part)partsDataGrid.CurrentRow.DataBoundItem;
                ModifyPart modifyForm = new ModifyPart(selectedPart);
                modifyForm.ShowDialog();
            }
        }
        //does not delete a part if associated with product
        private void deletePartsButton_Click(object sender, EventArgs e)
        {
            if (partsDataGrid.CurrentRow == null) return;

            Part selectedPart = (Part)partsDataGrid.CurrentRow.DataBoundItem;

            foreach (Product prod in Inventory.Products)
            {
                if (prod.AssociatedParts.Contains(selectedPart))
                {
                    MessageBox.Show($"Cannot delete part: It is currently associated with {prod.Name}.");
                    return;
                }
            }
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Inventory.DeletePart(selectedPart);
            }
        }

        private void productsDeleteButton_Click(object sender, EventArgs e)
        {
            if (productsDataGrid.CurrentRow == null || !productsDataGrid.CurrentRow.Selected)
            {
                MessageBox.Show("Select a product to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Product selectedProduct = (Product)productsDataGrid.CurrentRow.DataBoundItem;
                if (selectedProduct.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete a product that has parts associated with it; please remove the parts first.");
                    return;
                }

                Inventory.RemoveProduct(selectedProduct.ProductID);
            }
        }

        private void productsAddButton_Click(object sender, EventArgs e)
        {
            addProductWindow addForm = new addProductWindow();
            addForm.ShowDialog();
        }

        private void productsModifyButton_Click(object sender, EventArgs e)
        {
            if (productsDataGrid.CurrentRow != null)
            {
                Product selectedProduct = (Product)productsDataGrid.CurrentRow.DataBoundItem;
                ModifyProduct modifyForm = new ModifyProduct(selectedProduct);
                modifyForm.ShowDialog();
            }
        }
    }
}
