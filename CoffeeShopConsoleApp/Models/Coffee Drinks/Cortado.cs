using CoffeeShopConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp.Models
{
    class Cortado: Coffee, IMilk
    {
        public int MilkAmountInMLs()
        {
            return 40;
        }

        public override int price()
        {
            return 25 - DiscountAmount;
        }

        public override string Strength()
        {
            return "Medium";
        }
        public Cortado(int discAmount, CoffeeBlend blend) : base(discAmount, blend)
        {
            DiscountAmount = discAmount;
            MyCoffeeBlend = blend;
        }
    }
}
