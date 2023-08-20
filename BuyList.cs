using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuylistNamespace
{
    internal class BuyList
    {
        private List<Product> product;

        public BuyList()
        {
            product = new List<Product>();
        }

        public void addProduct(Product productAdding)
        {
            product.Add(productAdding);
            Console.WriteLine("Product has been added.");
        }

        public void removeProductByName(string name)
        {
            Product productAfterName = product.FirstOrDefault(product => product.Name == name);
            product.Remove(productAfterName);

            Console.WriteLine("Product has been removed.");
        }

        public List<Product> getProducts()
        {
            return product;
        }
    }
}
