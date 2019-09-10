using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public abstract class Customer
    {
        //TODO: Maybe put recipe in customer class
        public int buyLemonade;
        public int customers;

        public Day Day
        {
            get => default;
            set
            {
            }
        }

        public Customer()
        {
            this.buyLemonade = 0;
            this.customers = 0;
            
        }

        public abstract int BuyLemonadeBasedOnTemperature(Day day);

        public abstract int BuyLemonadeBasedOnWeather(Day day);

        public abstract int BuyLemonadeBasedOnIngredients(Day day);

        public abstract int PriceOfLemonade(Day day);
        
            

        


        


    }
}