using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {
        
        
        
        public Day Day
        {
            get => default;
            set
            {
            }
        }

        public Weather()
        {
            Random rng = new Random();
            int weather = rng.Next();

        }
            
          

        public void GenerateWeather()
        {
            List<string> weather = new List<string> { "Rainy", "Sunny", "Cloudy", "Windy", "Cloudy & Windy", "Sunny & Windy" };
            
            Random rng = new Random();
            
            foreach (string Weather in weather)
            {
                Console.WriteLine(Weather);
            }

        }

    }

}