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

            // coffee that has milk
            List<IMilk> coffeeWithMilk = new List<IMilk>();

            // a list of all the orders for coffee in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new Cortado(2),
                new Latte(5),
                new BlackCoffee(10),
                new Cappucino (20)

            };


            foreach (var coffeeItem in orderList)
            {
                Console.WriteLine("the Price/Strength  of the " + coffeeItem.GetType().Name +" is : "+ coffeeItem.price() + " / " + coffeeItem.Strength());

                // Add the coffees that contain milk to the milk only coffee list
                if(coffeeItem is IMilk)
                {                    
                    if((coffeeItem as IMilk).MilkAmountInMLs() > 0)
                    {
                        coffeeWithMilk.Add(coffeeItem as IMilk);
                    }             
                }
            }

            // print out the names of the coffees that contain milk
            List<string> namesOfCoffeeWithMilk = new List<string>();
            
            foreach (var coffee in coffeeWithMilk)
            {
                namesOfCoffeeWithMilk.Add(coffee.GetType().Name);
            }

            Console.WriteLine("Coffees that contain milk: ");
            namesOfCoffeeWithMilk.ForEach(Console.WriteLine);

        }
    }
}
