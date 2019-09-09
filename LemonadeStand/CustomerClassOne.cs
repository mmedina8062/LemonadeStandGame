using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class CustomerClassOne : Customer
    {
        public Customer Customer
        {
            get => default;
            set
            {

            }


        }


        public CustomerClassOne()
        {

        }

        public override bool BuyLemonadeBasedOnWeather(Day day)
        {

            if (day.weather.temperature == 97 || day.weather.temperature > 60)
            {

                return true;
            }
            return true;

        }

        public override bool BuyLemonadeBasedOnIngredients(Day day)
        {
            if (day.Lemons == 5 || day.Lemons > 3)
            {
                return true;
            }
            return true;
        }

    }
}