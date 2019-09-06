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
                    player.inventory.Lemons += 10;
                    break;
                case "Sugar":
                    GetBuySugar(player);
                    player.inventory.Sugar += 20;
                    break;                  
                case "Cups":
                    GetBuyCups(player);
                    player.inventory.Cups += 20;
                    break;
                case "Ice Cubes":
                    GetBuyIceCubes(player);
                    player.inventory.IceCubes += 100;
                    break;
                    

            }

            return player.inventory.Lemons + player.inventory.Sugar + player.inventory.Cups + player.inventory.IceCubes; 
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
            Console.WriteLine();
            return Lemons;

        }

        public int GetBuySugar(Player player)
        {
            Console.WriteLine("Choose amount of Sugar to purchase: 20 lbs = $1.50, 45 lbs = $2.50, 75 lbs = $3.50");
            string UserInput = Console.ReadLine();

            if (UserInput == "")
            {
                int AmountOfMoneyLeft = player.startingAmount - int.Parse(UserInput);

                Console.WriteLine(AmountOfMoneyLeft);
            }
            return Sugar;
        }

        public int GetBuyCups(Player player)
        {
            Console.WriteLine("Choose amount of Cups to purchase: 20 cups = $.95, 50 cups = $1, 100 cups = $2");
            string UserInput = Console.ReadLine();

            if (UserInput == "")
            {
                int AmountOfMoneyLeft = player.startingAmount - int.Parse(UserInput);

                Console.WriteLine(AmountOfMoneyLeft);
            }
            return Cups;
        }

        public int GetBuyIceCubes(Player player)
        {
            Console.WriteLine("Choose amount of Ice Cubes to purchase: 100 ice cubes = $2, 250 ice cubes = $3, 450 ice cubes = $4");
            string UserInput = Console.ReadLine();

            if (UserInput == "")
            {
                int AmountOfMoneyLeft = player.startingAmount - int.Parse(UserInput);

                Console.WriteLine(AmountOfMoneyLeft);
            }
            return IceCubes;
        }
       

        
    }
}