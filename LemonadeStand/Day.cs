using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        public Weather weather;
        public string day;
        public int Lemons;
        public int Sugar;
        public int pricePerCup;
        public int IceCubes;
        public LemonadeGame LemonadeGame
        {
            get => default;
            set
            {
            }
        }

        public Day()
        {
            //weather = new Weather();
            
            this.day = "";
            this.Lemons = LemonadeGame.player.inventory.Lemons;
            this.Sugar = LemonadeGame.player.inventory.Sugar;
            this.IceCubes = LemonadeGame.player.inventory.IceCubes;




        }

        public void RecipeAndPrice(int Lemons, int Sugar, int pricePerCup, int IceCubes)
        {
            string[] ingredients = new string[] { "Lemons", "Sugar", "Ice Cubes", "Cups" };

            for (int i = 0; i <= ingredients.Length; i++)
            {
                if (ingredients[i] == "Lemons")
                {
                    Console.WriteLine("Enter amount of Lemons per pitcher: ");
                    string UserInput = Console.ReadLine();
                    //TODO: subtract amount from iventory
                    

                }
                else if (ingredients[i] == "Sugar")
                {
                    Console.WriteLine("Enter amount of Sugar per pitcher: ");
                    string UserInput = Console.ReadLine();
                    

                }
                else if (ingredients[i] == "Ice Cubes")
                {
                    Console.WriteLine("Enter amount of Ice Cubes per Cup: ");
                    string UserInput = Console.ReadLine();
                    

                }
                else if (ingredients[i] == "Cups")
                {
                    Console.WriteLine("Enter price per Cup: ");
                    string UserInput = Console.ReadLine();
                   

                }
            }

            
             


            //TODO: create a calculator to subtract amount customer purchase from inventory

        }

        public string DayOfWeek()
        {
            
            string[] DayOfWeek = new string[] { "Day One", "Day Two", "Day Three", "Day Four", "Day Five", "Day Six", "Day Seven" };

            for (int i = 0; i <= DayOfWeek.Length; i++)
            {

                if (DayOfWeek[i] == "Day One") 
                {
                    Console.WriteLine(DayOfWeek[i] + " " + "Weather: " + weather.GenerateWeather() + "|" + "Temperature: " + weather.GenerateTemperature());
                    Console.ReadLine();
                }
                else if (DayOfWeek[i] == "Day Two")
                {
                    Console.WriteLine(DayOfWeek[i] + " " + "Weather: " + weather.GenerateWeather() + " " + "Temperature: " + weather.GenerateTemperature());
                    Console.ReadLine();
                }
                else if (DayOfWeek[i] == "Day Three")
                {
                    Console.WriteLine(DayOfWeek[i] + " " + "Weather: " + weather.GenerateWeather() + " " + "Temperature: " + weather.GenerateTemperature());
                    Console.ReadLine();
                }
                else if (DayOfWeek[i] == "Day Four")
                {
                    Console.WriteLine(DayOfWeek[i] + " " + "Weather: " + weather.GenerateWeather() + " " + "Temperature: " + weather.GenerateTemperature());
                    Console.ReadLine();
                }
                else if (DayOfWeek[i] == "Day Five")
                {
                    Console.WriteLine(DayOfWeek[i] + " " + "Weather: " + weather.GenerateWeather() + " " + "Temperature: " + weather.GenerateTemperature());
                    Console.ReadLine();
                }
                else if (DayOfWeek[i] == "Day Six")
                {
                    Console.WriteLine(DayOfWeek[i] + " " + "Weather: " + weather.GenerateWeather() + " " + "Temperature: " + weather.GenerateTemperature());
                    Console.ReadLine();
                }
                else if (DayOfWeek[i] == "Day Seven")
                {
                    Console.WriteLine(DayOfWeek[i] + " " + "Weather: " + weather.GenerateWeather() + " " + "Temperature: " + weather.GenerateTemperature());
                    Console.ReadLine();
                }

            }
            return day;
            
        }

   
    }

}