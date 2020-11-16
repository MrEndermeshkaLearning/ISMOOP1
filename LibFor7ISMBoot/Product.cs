using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LibFor7ISMBoot
{
   public class Product
    {
        public string Name { protected set; get; }
        public double Price { protected set; get; }
        public Currency Cost { protected set; get; }
        public int Quantity { protected set; get; }
        public string Producer { protected set; get; }
        public double Weight { protected set; get; }
        public Product()
        {
            Name = "Example";
            Price = 1024.512;
            Cost = new Currency();
            Quantity = 256;
            Producer = "Microsoft";
            Weight = 12.300;
        }
        public Product(string name, Double price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(string name, Double price, Currency cost, int quantity, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = "NoName";
            Weight = weight;
        }
        public Product(Product pt)
        {
            Name = pt.Name;
            Price = pt.Price;
            Cost = pt.Cost;
            Quantity = pt.Quantity;
            Producer = pt.Producer;
            Weight = pt.Weight;
        }
        public double GetTotalPriceInUAH()
        {
            double res = this.Cost.ExRate * this.Price * this.Quantity;
            return res;
        }
        public double GetPriceInUAH()
        {
            double res = this.Cost.ExRate * this.Price;
            return res;
        }
        public double GetTotalWeight()
        {
            return this.Weight * this.Quantity;
        }
    }
}
