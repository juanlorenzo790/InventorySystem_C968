using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    public class Product
    {
        //holds all the parts assignes
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min {  get; set; }
        public int Max { get; set; }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public bool RemoveAssociatedPart(int partID)
        {
            foreach (var part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return true;
                }
            }
            return false;
        }
        public Part LookupAssociatedPart(int partID)
        {
            foreach(var part in AssociatedParts)
            {
                if(part.PartID == partID) { return part; }
            }
            return null;
        }

    }
}
