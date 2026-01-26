using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    public static class Inventory
    {
        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static BindingList<Product> Products = new BindingList<Product>();
        public static void AddPart(Part part) => AllParts.Add(part);

        public static bool DeletePart(Part part) => AllParts.Remove(part);
        //updaed pars in the list
        public static void UpdatePart(int partID, Part updatedPart)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partID)
                {
                    AllParts[i] = updatedPart;
                    return;
                }
            }
        }
        //searches all parts list for id match
        public static Part LookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID) return part;
            }
            return null;
        }

        public static BindingList<Part> LookupPart(string partName)
        {
            BindingList<Part> filteredParts = new BindingList<Part>();
            foreach (Part part in AllParts)
            {
                if (part.Name.ToUpper().Contains(partName.ToUpper()))
                {
                    filteredParts.Add(part);
                }
            }
            return filteredParts;
        }

        public static void AddProduct(Product product) => Products.Add(product);

        public static bool RemoveProduct(int productID)
        {
            foreach (Product p in Products)
            {
                if (p.ProductID == productID)
                {
                    Products.Remove(p);
                    return true;
                }
            }
            return false;
        }

        public static void UpdateProduct(int productID, Product updatedProduct)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID)
                {
                    Products[i] = updatedProduct;
                    return;
                }
            }
        }

        public static Product LookupProduct(int productID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == productID) return prod;
            }
            return null;
        }

        public static BindingList<Product> LookupProduct(string productName)
        {
            BindingList<Product> filteredProducts = new BindingList<Product>();
            foreach (Product prod in Products)
            {
                if (prod.Name.ToUpper().Contains(productName.ToUpper()))
                {
                    filteredProducts.Add(prod);
                }
            }
            return filteredProducts;
        }
    }
}
