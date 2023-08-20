using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuylistNamespace
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Boolean power = true;
            BuyList buyList = new BuyList();
            while (power == true)
            { 

                Console.WriteLine("Welcome to your buy list.");
                Console.WriteLine("Press 1 to see your buy list.");
                Console.WriteLine("Press 2 to add a product.");
                Console.WriteLine("Press 3 to remove a product.");
                Console.WriteLine("Press 4 to stop the program.");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 1)
                {

                    List<Product> getBuyList = buyList.getProducts();
                    if (getBuyList.Count == 0)
                    {
                        Console.WriteLine("Oh, you don't have added a product yet, may you try add one now? You only need to press 2.");
                    }
                    else
                    {
                        Console.WriteLine("Buy List: ");
                        foreach (var product in getBuyList) {
                            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
                        }
                    }
                }
                if (number == 2)
                {
                    Console.WriteLine("Alright, what's the product name?");
                    string name = Console.ReadLine();

                    Console.WriteLine("Now what's the product price?");
                    int price = Convert.ToInt32(Console.ReadLine());

                    Product product = new Product(name, price);
                    buyList.addProduct(product);
                }
                if (number == 3)
                {
                    Console.WriteLine("Alright, what's the product's name of the product you want to delete?");
                    List<Product> getBuyList = buyList.getProducts();

                    Console.WriteLine("Buy List: ");
                    foreach (var product in getBuyList)
                    {
                        Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
                    }

                    string deleteName = Console.ReadLine();

                    buyList.removeProductByName(deleteName);
                    Console.WriteLine($"The product {deleteName} has been deleted. Now, get the updated list");

                    List<Product> getBuyListUpdated = buyList.getProducts();

                    Console.WriteLine("Buy List: ");
                    foreach (var product in getBuyListUpdated)
                    {
                        Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
                    }
                }
                if (number == 4)
                {
                    power = false;
                }
            }
        }
    }
}