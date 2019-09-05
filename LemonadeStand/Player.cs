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
            
            

        }

        public int StartingAmount()
        {
            string StartingAmount = 25.ToString("C");

            return startingAmount;
            
        }

        public void AccessPlayerInventory()
        {

            //Console.WriteLine(Inventory.PlayerInventory);
            
        }

     



    }
}