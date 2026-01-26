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
    public partial class AddingPartPage : Form
    {
        public AddingPartPage()
        {
            InitializeComponent();
            int maxId = 0;
            foreach (Part p in Inventory.AllParts)
            {
                if(p.PartID > maxId) maxId = p.PartID;
            }
            int newId = Inventory.AllParts.Count + 1;
            addPartTxtBoxid.Text = newId.ToString();
        }

        private void addPartInHouseRadButton_CheckedChanged(object sender, EventArgs e)
        {
            addPartLabelMachid.Text = "Machine ID";
        }

        private void AddPartOutsourcedRadButton_CheckedChanged(object sender, EventArgs e)
        {
            addPartLabelMachid.Text = "Company Name";
        }

        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPartSaveButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(addPartTxtBoxInventory.Text, out int inventory) ||
        !decimal.TryParse(addPartTxtBoxPriCos.Text, out decimal price) ||
        !int.TryParse(addPartTxtBoxMax.Text, out int max) ||
        !int.TryParse(addPartTxtBoxMin.Text, out int min))
            {
                MessageBox.Show("Inventory, Price, Max, and Min must be numeric values.");
                return;
            }

            if (min > max)
            {
                MessageBox.Show("Min cannot be greater than Max.");
                return;
            }
            if (inventory < min || inventory > max)
            {
                MessageBox.Show("Inventory must be between the Min and Max values.");
                return;
            }

            int id = int.Parse(addPartTxtBoxid.Text);
            string name = addPartTxtBoxName.Text;

            if (addPartInHouseRadButton.Checked)
            {
                if (!int.TryParse(addPartTxtBoxMachid.Text, out int machId))
                {
                    MessageBox.Show("Machine ID must be a numeric value.");
                    return;
                }
                Inventory.AddPart(new InHouse { PartID = id, Name = name, InStock = inventory, Price = price, Max = max, Min = min, MachineID = machId });
            }
            else
            {
                string companyName = addPartTxtBoxMachid.Text;
                Inventory.AddPart(new Outsourced { PartID = id, Name = name, InStock = inventory, Price = price, Max = max, Min = min, CompanyName = companyName });
            }

            this.Close();
        }
    }
}
