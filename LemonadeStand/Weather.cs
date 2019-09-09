using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {
        public string weather;
        
        
        
        public Day Day
        {
            get => default;
            set
            {
            }
        }

        public Weather()
        {
            this.weather = ""; 

        }
            
          

        public string GenerateWeather(Day day)
        {
            List<string> weather = new List<string> { "Rainy", "Sunny", "Cloudy", "Windy", "Cloudy & Windy", "Sunny & Windy" }; ;
            Random r = new Random();
            int index = r.Next(weather.Count);
            string randomString = weather[index];
            Console.WriteLine(randomString);
            Console.ReadLine();

            return randomString;

        }

    }

}