using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsMyPizza
{
   public class Pizza
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Crust { get; set; }

        public string Toppings { get; set; }

        public Pizza(Tuple<string, int> PizzaNameAndBasePrice)
        {
            this.Name = PizzaNameAndBasePrice.Item1;
            this.Price = PizzaNameAndBasePrice.Item2;
        }

        public void display()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Crust);
            Console.WriteLine(this.Toppings);
            Console.WriteLine(this.Quantity);
            Console.WriteLine(this.Price * this.Quantity);

        }
      

    }
}
