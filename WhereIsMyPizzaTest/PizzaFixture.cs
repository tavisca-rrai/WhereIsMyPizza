using System;
using WhereIsMyPizza;
using Xunit;
using FluentAssertions;

namespace WhereIsMyPizzaTest
{
    public class PizzaFixture
    {
        
        
        [Fact]
        public void GetPizzaNameAndPrice()
        {
            var PizzaName = PizzaProvider.PizzaAndPriceList[0];
            var actualOutput = new Pizza(PizzaName);

            var expectedOutput = new Pizza() { Name = "Margherita", Price = 150 };

            actualOutput.Should().Be(expectedOutput);
        }

        [Fact]
        public void GetCrust()
        {
            var actualOutput = new Pizza() { };
            //getcrust
            var crustName = PizzaProvider.Crusts[0];
            actualOutput.Crust = crustName.Item1;

            var expectedOutput = new Pizza() { Crust = "Thin Crust" };

            actualOutput.Should().Be(expectedOutput);
        }
        [Fact]
        public void GetToppings()
        {
            var actualOutput = new Pizza() { };
            //getcrust
            var toppingsName = PizzaProvider.Toppings[0];
            actualOutput.Toppings = toppingsName.Item1;

            var expectedOutput = new Pizza() { Toppings = "Pepperoni" };

            actualOutput.Should().Be(expectedOutput);
        }

    }
}
