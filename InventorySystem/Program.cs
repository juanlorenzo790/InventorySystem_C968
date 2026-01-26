using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Inventory.AddPart(new InHouse    //sample parts
            {
                PartID = 1,
                Name = "Pedal",
                Price = 10.00m,
                InStock = 25,
                Min = 3,
                Max = 35,
                MachineID = 105
            });
            Inventory.AddPart(new Outsourced 
            {
                PartID = 2,
                Name = "Chain",
                Price = 35.00m,
                InStock = 40,
                Min = 10,
                Max = 75,
                CompanyName = "Rapid"
            });

            Product bike = new Product  //sample products
            {
                ProductID = 1,
                Name = "Light Bike",
                Price = 225.00m,
                InStock = 5,
                Min = 1,
                Max = 50,
            };
            bike.AddAssociatedPart(Inventory.LookupPart(1));
            Inventory.AddProduct(bike);
            Application.Run(new mainPage());
        }
    }
}
