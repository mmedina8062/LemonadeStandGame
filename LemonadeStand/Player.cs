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
        int ingridentsControl;
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
            inventory = new Inventory();
            this.PickSellDay = 7;
            this.startingAmount = 25.ToString("C"); //change string to int



        }



        public int Wallet()
        {
            string StartingAmount = 25.ToString("C");
            Console.WriteLine(StartingAmount);

        }
        public string Recipe()
        {
            Console.WriteLine("Amount of Lemons: ");
            string UserInput = Console.ReadLine();

            if (UserInput == "")
            {
                Console.WriteLine(int.Parse(UserInput) - inventory.Lemons);

            }
            

        }
    }
}