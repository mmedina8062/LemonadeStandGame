using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class CustomerClass2 : Customer
    {

        public CustomerClass2()
        {

        }

        public override int BuyLemonadeBasedOnTemperature(Day day)
        {
            if (day.weather.temperature == 89 || day.weather.temperature > 70)
            {

                return customers = 60;
            }
            return customers = 60;

        }

        public override int BuyLemonadeBasedOnWeather(Day day)
        {
            if (day.weather.weather == "Sunny" || day.weather.weather == "Sunny & Windy" || day.weather.weather == "Rainy" || day.weather.weather == "Rainy & Sunny")
            {
                return customers = 50;
            }
            return customers = 50;
        }

        public override int BuyLemonadeBasedOnIngredients(Day day)
        {
            if (day.Lemons == 5 || day.Lemons > 3 && day.Sugar == 5 || day.Sugar > 3 && day.IceCubes == 5 || day.IceCubes > 3)
            {
                return customers = 45;
            }
            return customers = 45;
        }

        public override int PriceOfLemonade(Day day)
        {
            if (day.pricePerCup == 0.25 || day.pricePerCup > 0.10)
            {
                return customers = 40;
            }
            return customers = 40;
        }
    }

    //TODO: create else if for all methods
}