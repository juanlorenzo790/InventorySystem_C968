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
    public partial class ModifyPart : Form
    {
        private Part _partToModify;
        public ModifyPart(Part selectedPart)
        {
            InitializeComponent();
            _partToModify = selectedPart;

            modiPartTxtBoxid.Text = _partToModify.PartID.ToString();
            modiPartTxtBoxName.Text = _partToModify.Name;
            modiPartTxtBoxInventory.Text = _partToModify.InStock.ToString();
            modiPartTxtBoxPriCos.Text = _partToModify.Price.ToString();
            modiPartTxtBoxMax.Text = _partToModify.Max.ToString();
            modiPartTxtBoxMin.Text = _partToModify.Min.ToString();

            if (_partToModify is InHouse inPart)
            {
                modipartInHouseRadButton.Checked = true;
                modiPartLabelMachid.Text = "Machine ID";
                modiPartTxtBoxMachid.Text = inPart.MachineID.ToString();
            }
            else if (_partToModify is Outsourced outPart)
            {
                modiPartOutsourcedRadButton.Checked = true;
                modiPartLabelMachid.Text = "Company Name";
                modiPartTxtBoxMachid.Text = outPart.CompanyName;
            }
        }

        private void modiPartSaveButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(modiPartTxtBoxInventory.Text, out int inventory) ||
        !decimal.TryParse(modiPartTxtBoxPriCos.Text, out decimal price) ||
        !int.TryParse(modiPartTxtBoxMax.Text, out int max) ||
        !int.TryParse(modiPartTxtBoxMin.Text, out int min))
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

            int id = int.Parse(modiPartTxtBoxid.Text); 
            string name = modiPartTxtBoxName.Text;

            if (modipartInHouseRadButton.Checked)
            {
                if (!int.TryParse(modiPartTxtBoxMachid.Text, out int machId))
                {
                    MessageBox.Show("Machine ID must be numeric.");
                    return;
                }

                InHouse updatedInHouse = new InHouse { PartID = id, Name = name, InStock = inventory, Price = price, Max = max, Min = min, MachineID = machId };
                Inventory.UpdatePart(id, updatedInHouse);
            }
            else
            {
                string companyName = modiPartTxtBoxMachid.Text;

                Outsourced updatedOutsourced = new Outsourced { PartID = id, Name = name, InStock = inventory, Price = price, Max = max, Min = min, CompanyName = companyName };
                Inventory.UpdatePart(id, updatedOutsourced);
            }

            this.Close();
        }

        private void modipartInHouseRadButton_CheckedChanged(object sender, EventArgs e)
        {
            modiPartLabelMachid.Text = "Machine ID";
        }

        private void modiPartOutsourcedRadButton_CheckedChanged(object sender, EventArgs e)
        {
            modiPartLabelMachid.Text = "Company Name";
        }
    }
}
