using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp.Models
{
    class BlackCoffee: Coffee
    {
        public override int price()
        {
            return 20 - DiscountAmount;
        }
        public override string Strength()
        {
            return "Strong";
        }

        public BlackCoffee(int discAmount, CoffeeBlend blend) : base(discAmount, blend)
        {
            DiscountAmount = discAmount;
            MyCoffeeBlend = blend;
        }
    }
}
