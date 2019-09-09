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
        public int customer;

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
            this.customer = 0;
        }

        public abstract bool BuyLemonade(Day day);
        
            

        


        


    }
}