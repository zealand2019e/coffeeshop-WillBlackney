using CoffeeShopConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp.Models
{
    public class Cappucino: Coffee, IMilk
    {
        public int MilkAmountInMLs()
        {
            return 40;
        }

        public override int price()
        {
            return 45 - DiscountAmount;
        }

        public override string Strength()
        {
            return "Medium";
        }
        public Cappucino(int discAmount) : base(discAmount)
        {
            DiscountAmount = discAmount;
        }
    }
}
}
