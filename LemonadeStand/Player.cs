using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Player
    {
        
        int PickSellDay;
        int PriceForLemonade;
        //TODO: calculator to add money made from sales and incorporate that to add with StartingAmount
        int IngridentsControl;
        public int startingAmount;
        public Inventory inventory;        
        


        public LemonadeGame LemonadeGame
        {
            get => default;
            set
            {
            }
        }

        public Player()
        {
            this.inventory = Inventory.inventory;  
          

        }

        public int StartingAmount(Store store)
        {
            string StartingAmount = 25.ToString("C");

            return store.Lemons + store.Sugar + store.Cups + store.IceCubes;
            
        }

        

     



    }
}