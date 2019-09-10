using CoffeeShopConsoleApp.Interfaces;
using CoffeeShopConsoleApp.Models;
using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // coffees that contain milk
            List<IMilk> coffeeWithMilk = new List<IMilk>();

            // a list containing the coffees for this order
            List<Coffee> orderList = new List<Coffee>()
            {
                // Construct 4 coffee objects, and add to the order list
                new Cortado(2, Coffee.CoffeeBlend.Hermosa),
                new Latte(5, Coffee.CoffeeBlend.Kieni),
                new BlackCoffee(10, Coffee.CoffeeBlend.Konyu),
                new Cappucino (20, Coffee.CoffeeBlend.Akmel)
            };


            // Print the name, price, strength and coffee blend of each coffee in the order
            foreach (var coffeeItem in orderList)
            {
                    Console.WriteLine("The Price/Strength of the " + coffeeItem.GetType().Name +
                    " blended with " + coffeeItem.MyCoffeeBlend.ToString() + " is: " +
                    coffeeItem.price() + " / " + coffeeItem.Strength());

                // Add ONLY the coffees that contain milk to the milk only coffee list
                if(coffeeItem is IMilk)
                {                    
                    if((coffeeItem as IMilk).MilkAmountInMLs() > 0)
                    {
                        coffeeWithMilk.Add(coffeeItem as IMilk);
                    }             
                }
            }

            // Print out the names of the coffees that contain milk
            Console.WriteLine("Coffees that contain milk: ");
            foreach (var coffee in coffeeWithMilk)
            {
                Console.WriteLine(coffee.GetType().Name);
            }


        }
    }
}
