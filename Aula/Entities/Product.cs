using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Aula.Entities
{
    class Product
    {
        public string Name { get; set; } // Atributos da classe tipo string
        public double Price { get; set; } // Atribbuto da classe tipo double

        public Product() //Construtor padrão da classe
        {

        }

        public Product(string name, double price) //Construtor recebendo os argumentos
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag() // Método virtual para imprimir e ser reutilizado nas sub classes
        {
            return Name + " $" + Price.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
