using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Store
    {
        public int Lemons;
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

        public int StoreItems(Player player)
        {
            Console.WriteLine("Please choose which ingrident you like to purchase: (Lemons, Sugar, Cups, or Ice Cubes)");
            string UserInput = Console.ReadLine();

            switch (UserInput)
            {    
                case "Lemons":
                    GetBuyLemons(player);
                    //player.AccessPlayerInventory();
                    player.inventory.Lemon += 10;
                    break;
                case "Sugar":
                    GetBuySugar(player);
                    //Player.AccessPlayerInventory();
                    player.inventory.Sugar += 20;
                    break;
                    
                case "Cups":
                    break;

                case "Ice Cubes":
                    break;
                    

            }

            return (int)Lemons; 
            //TODO: create day  

        }

        public int GetBuyLemons(Player player)
        {
            
            Console.WriteLine("Choose amount of Lemons to purchase: 10 = $1, 40 = $2, 65 = $3");
            string UserInput = Console.ReadLine();  

            if (UserInput == "")
            {
                
                int AmountOfMoneyLeft = player.startingAmount - int.Parse(UserInput);

                Console.WriteLine(AmountOfMoneyLeft);               
            }
            return Convert.ToInt32(UserInput);

        }

        public void GetBuySugar(Player player)
        {
            Console.WriteLine("Choose amount of Sugar to purchase: 20 lbs = $1.50, 45 lbs = $2.50, 75 lbs = $3.50");
            string UserInput = Console.ReadLine();

            if (UserInput == "")
            {
                int AmountOfMoneyLeft = player.startingAmount - int.Parse(UserInput);

                Console.WriteLine(AmountOfMoneyLeft);
            }
        }
       

        
    }
}