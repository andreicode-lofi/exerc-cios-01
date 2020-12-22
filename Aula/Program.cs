using System;
using System.Globalization;
using System.Collections.Generic;
using Aula.Entities;


namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>(); // Instanciando uma lista para fazer uma leitura dos produtos

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) // For para fazer a repetição e o registro dos produtos
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{i+1} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char rsp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(rsp == 'i' || rsp == 'I') // Se o produtor for importado
                {
                    Console.Write("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);// Variável para o usuario dicione a taxa do produto importado
                    list.Add(new ImportedProduct(name, price, customs)); //Adicionando dados dos produtos importado
                }
                else if(rsp == 'u' || rsp == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());// Variável para o usuario dicione a data do produto usado
                    list.Add(new UsedProduct(name, price, date));//Adicinando dados dos produtos usados
                }
                else
                {
                    list.Add(new Product(name, price));//adicionando dados dos produtos comum
                }

                Console.WriteLine();
                Console.WriteLine("Price tags: ");
                foreach(Product product in list)// foreach para percorrer a lista
                {
                    Console.WriteLine(product.PriceTag());
                }

            }
        }    
    }
}
