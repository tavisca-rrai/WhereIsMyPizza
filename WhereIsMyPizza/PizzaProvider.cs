using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsMyPizza
{
    static public class PizzaProvider
    {
        public static List<Tuple<string, int>> PizzaAndPriceList = new List<Tuple<string, int>>
        {
            Tuple.Create( "Margherita", 150 ),
            Tuple.Create( "icciosa" , 100 ),
            Tuple.Create( "Stagioni", 200 )
        };

        public static List<Tuple<string,int>> Crusts = new List<Tuple<string,int>>
        {
            Tuple.Create("Thin Crust",50),
            Tuple.Create("Thick Crust",50),
            Tuple.Create("Deep Crust",50),
            Tuple.Create("Cheese Filled Crust",50),
            Tuple.Create("Stuffed Crust",50)
        };

        public static List<Tuple<string, int>> Toppings = new List<Tuple<string, int>>
        {
            Tuple.Create("Pepperoni",50),
            Tuple.Create("Mushrooms",50),
            Tuple.Create("Sausage",50),
            Tuple.Create("Onions",50),
            Tuple.Create("Bacon",50),

        };
        public static void DisplayToppings()
        {
            int toppingsNumber = 0;
            foreach (Tuple<string, int> Topping in Toppings)
            {
                Console.WriteLine("Topping Number - {$} : ", toppingsNumber++, Topping.Item1 + "Costs {$} Rs", Topping.Item2);
            }
        }
        public static void DisplayCrust()
        {
            int crustNumber=0;
            foreach (Tuple<string,int> Crust in Crusts)
            {
                Console.WriteLine("Crust Number - {$} : ", crustNumber++, Crust.Item1 + "Costs {$} Rs", Crust.Item2);
            }
        }
     
        public static void DisplayPizzaNameAndPrice()
        {
            int pizzaNumber=0;
            foreach(Tuple<string, int> NameAndPrice in PizzaAndPriceList)
            {
                Console.Write("PizzaNumber-{$}",pizzaNumber++,NameAndPrice.Item1 + "Costs {$} Rs", NameAndPrice.Item2);
            }
        }
    }
}