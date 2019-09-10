using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class CustomerClassOne : Customer
    {


        public CustomerClassOne()
        {


        }

        public override int BuyLemonadeBasedOnTemperature(Day day)
        {

            if (day.weather.temperature == 97 || day.weather.temperature > 60)
            {

                return customers = 120;
            }
            return customers = 120;

        }

        public override int BuyLemonadeBasedOnWeather(Day day)
        {
            if (day.weather.weather == "Sunny" || day.weather.weather == "Sunny & Windy" || day.weather.weather == "Cloudy & Windy" || day.weather.weather == "Rainy & Sunny" || day.weather.weather == "Rainy & Cloudy")
            {
                return customers = 75;
            }
            return customers = 75;
        }

        public override int BuyLemonadeBasedOnIngredients(Day day)
        {

            if (day.Lemons == 5 || day.Lemons > 3 && day.Sugar == 5 || day.Sugar > 3 && day.IceCubes == 5 || day.IceCubes > 3)
            {

                return customers = 60;
            }
            return customers = 60;
        }

    }
}