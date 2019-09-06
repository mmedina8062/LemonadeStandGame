using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        public Weather weather;
        public LemonadeGame LemonadeGame
        {
            get => default;
            set
            {
            }
        }

        public Day()
        {
            weather = new Weather();
            
        }

        public void DayOfWeek()
        {
            List<string> DayOfWeek = new List<string> { "Day 1", "Day 2", "Day 3", "Day 4", "Day 5", "Day 6", "Day 7" };

            foreach (string day in DayOfWeek)
            {
                Console.WriteLine(day);

                for (DayOfWeek == "Day 1")

            }
        }
    }

}