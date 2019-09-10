using CoffeeShopConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp.Models
{
    class Latte: Coffee, IMilk
    {
        public int MilkAmountInMLs()
        {
            return 200;
        }

        public override int price()
        {
            return 40 - DiscountAmount;
        }

        public override string Strength()
        {
            return "Weak";
        }

        public Latte(int discAmount, CoffeeBlend blend) : base(discAmount, blend)
        {
            DiscountAmount = discAmount;
            MyCoffeeBlend = blend;
        }


    }
}
