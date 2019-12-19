using System;
using ExercicioProposto.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> list = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                /*if (c=='i')
                {
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (c == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else
                    list.Add(new Product(name, price));*/
                switch (c)
                {
                    case 'i':
                        Console.Write("Customs Fee: ");
                        double customsFee = double.Parse(Console.ReadLine());
                        list.Add(new ImportedProduct(name, price,customsFee));
                        break;

                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        list.Add(new UsedProduct(name, price, date));
                        break;
                        
                    default:
                        list.Add(new Product(name, price));
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
