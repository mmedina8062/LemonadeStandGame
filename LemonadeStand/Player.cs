using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Player
    {

        int PickSellDay;
        
        //TODO: calculator to add money made from sales and incorporate that to add with StartingAmount
        
        public int WalletAmount;
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
            inventory = new Inventory();
            this.PickSellDay = 7;
            this.WalletAmount = 25;//25.ToString("C2"); //change string to int



        }



        public int Wallet()
        {
            int WalletAmount = 25;//25.ToString("C2");
            Console.WriteLine(WalletAmount);

            return WalletAmount;

        }

    }
}