using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aula.Entities 
{
    class UsedProduct : Product // Herança da super classe product
    {
        public DateTime Date { get; set; } //Atributo DateTime da sub classe

        public UsedProduct() // Construtor padrão
        {

        }

        public UsedProduct(string name, double price, DateTime date) : base(name, price)
        // Construtor reutilizando os argumentos da super classe Product, e adicionando um novo argumento
        {
            Date = date;
        }

        public override string PriceTag() //Método reutilazo para imprimir os produtos usados
        {
            return Name + "(used) $" + Price.ToString("f2", CultureInfo.InvariantCulture) + "(Manufacture date:" + Date.ToString("dd/MM/yyyy") + ")";
        }

    }
}
