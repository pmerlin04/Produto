using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHerancaPolimorfismo2.Entities
{
    internal class Product
    {
        public string Name  { get; set; } //nome do produto
        public double Price { get; set; }//preço do produto
        //public List<Product> Products { get; set; } = new List<Product>();

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //etiqueta do produto
        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
