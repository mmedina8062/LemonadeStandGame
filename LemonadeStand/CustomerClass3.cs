using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class CustomerClass3 : Customer
    {



        public CustomerClass3()
        {


        }

        public override int BuyLemonadeBasedOnTemperature(Day day)
        {
            if (day.weather.temperature == 79 || day.weather.temperature > 50)
            {

                return customers = 75;
            }
            return customers = 75;

        }

        public override int BuyLemonadeBasedOnWeather(Day day)
        {
            if (day.weather.weather == "Sunny" || day.weather.weather == "Cloudy" || day.weather.weather == "Rainy" || day.weather.weather == "Rainy & Sunny" )
            {
                return customers = 40;
            }
            return customers = 40;
        }

        public override int BuyLemonadeBasedOnIngredients(Day day)
        {
            if (day.Lemons == 5 || day.Lemons > 1 && day.Sugar == 5 || day.Sugar > 1 && day.IceCubes == 5 || day.IceCubes > 1)
            {
                return customers = 45;
            }
            return customers = 45;
        }

        public override int PriceOfLemonade(Day day
)
        {
            if (day.pricePerCup == 0.20 || day.pricePerCup > 0.10)
            {
                return customers = 30;
            }
            return customers = 30;
        }
    }
}
