using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] InputNameData = Console.ReadLine()
                .Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

            string[] InputProductData = Console.ReadLine()
                .Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Person> peopleKvP = new Dictionary<string, Person>();
            Dictionary<string, Product> productKvP = new Dictionary<string, Product>();

            try
            {
                for (int i = 0; i < InputNameData.Length; i += 2)
                {
                    string name = InputNameData[i];
                    decimal money = decimal.Parse(InputNameData[i + 1]);

                    Person person = new Person(name, money);
                    peopleKvP.Add(name, person);
                }
                for (int j = 0; j < InputProductData.Length; j += 2)
                {
                    string name = InputProductData[j];
                    decimal cost = decimal.Parse(InputProductData[j + 1]);

                    Product product = new Product(name, cost);
                    productKvP.Add(name, product);
                }

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] commandNameAndProduct = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string personName = commandNameAndProduct[0];
                    string productName = commandNameAndProduct[1];

                    Person person = peopleKvP[personName];
                    Product product = productKvP[productName];

                    if (person.AddProduct(product))
                    {
                        Console.WriteLine($"{person.Name} bought {product.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} can't afford {product.Name}");
                    }

                    command = Console.ReadLine();

                }
                    foreach (var item in peopleKvP)
                    {
                        if (item.Value.Products.Count > 0)
                        {
                            Console.WriteLine($"{item.Value.Name} - {string.Join(", ", item.Value.Products.Select(x => x.Name))}");
                        }
                        else
                        {
                            Console.WriteLine($"{item.Value.Name} - Nothing bought");
                        }
                    }

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
