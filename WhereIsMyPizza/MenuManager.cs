using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WhereIsMyPizza
{
    public  class MenuManager
    {
        static public Pizza Instance;
        public static void DisplayPizza()
        {
            Console.WriteLine("Enter The Pizza Number To Select The Corresponding Pizza\n");
            PizzaProvider.DisplayPizzaNameAndPrice();
            
        }

        public static void GetPizza()
        {
            var pizzaNumber = int.Parse(Console.ReadLine());
            var PizzaName = PizzaProvider.PizzaAndPriceList[pizzaNumber];

            Instance = new Pizza(PizzaName);
            Console.Clear();

        }

        public static void GetCrust()
        {
            var crustNumber = int.Parse(Console.ReadLine());
            var crustName = PizzaProvider.Crusts[crustNumber];
            Instance.Crust = crustName.Item1;
            Instance.Price += crustName.Item2;
            Console.Clear();
        }

        public static void GetToppings()
        {
            var toppingNumber = int.Parse(Console.ReadLine());
            var toppingName = PizzaProvider.Toppings[toppingNumber];
            Instance.Toppings = toppingName.Item1;
            Instance.Price += toppingName.Item2;
            Console.Clear();
        }
        public static void GetQuantity()
        {
            Console.WriteLine("\nEnter the Quantity For your Pizza\n");
            Instance.Quantity = int.Parse(Console.ReadLine());
        }

        public static Pizza sendToCart()
        {
            return Instance;
        }

        public static void clearKitchen()
        {
            Instance = null;
        }
    }
}
