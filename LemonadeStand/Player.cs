using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Player
    {
        public string StartingAmount;
        int PickSellDay;
        int PriceForLemonade;
        //TODO: calculator to add money made from sales and incorporate that to add with StartingAmount


        public LemonadeGame LemonadeGame
        {
            get => default;
            set
            {
            }
        }

        public Player()
        {
            this.StartingAmount = 25.ToString("C");
            

        }

        public string InventoryNeeded()
        {
            Console.WriteLine();
        }

    }
}