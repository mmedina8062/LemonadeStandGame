using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Store
    {
        public string Lemons;
        public int Sugar;
        public int Cups;
        public int IceCubes;
        

        public LemonadeGame LemonadeGame
        {
            get => default;
            set
            {
            }
        }

        public Store()
        {
           
            
             
        }

        public void StoreItems()
        {
            Console.WriteLine("Please choose which ingrident you like to purchase: (Lemons, Sugar, Cups, or Ice Cubes)");
            string UserInput = Console.ReadLine();

            switch (UserInput)
            {
                case "Lemons":
                    int BuyLemons = Store.PriceOfItems;
                    break;

            }
          //TODO: create day  

        }

        public int PriceOfItems()
        {
            
            Console.WriteLine("Choose amount of Lemons to purchase: 10 = $1, 40 = $2, 65 = $3");
            string UserInput = Console.ReadLine();  

            if (UserInput == "")
            {
                int AmountOfMoneyLeft = SubtractTwoNumbers(Player.StartingAmount, UserInput);

                Console.WriteLine(AmountOfMoneyLeft);

            }
        }
        

        
    }
}