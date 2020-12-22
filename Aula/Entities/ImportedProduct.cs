using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aula.Entities
{
    class ImportedProduct : Product // Herença da super classe Product
    {
        public double CustomsFee { get; set; } //Atributo double da sub classe

        public ImportedProduct() // Construtor padrão
        {

        }

        public ImportedProduct(string name, double price, double importedProduct) : base (name, price)
        // Construtor reutilizando os argumentos da super classe Product, e adicionando um novo argumento
        {
            CustomsFee = CustomsFee;
        }

        public double TotalPrice()// Método adicionando a taxa de produtos importados
        {
            return Price += CustomsFee;
        }

        public override string PriceTag() //Método reutilizado para imprimir produtos importados
        {
            return Name + " $" + TotalPrice().ToString("f2", CultureInfo.InvariantCulture)
            + "( Customs fee: $" + CustomsFee.ToString("f2", CultureInfo.InvariantCulture) + ")";
        }



    }
}
