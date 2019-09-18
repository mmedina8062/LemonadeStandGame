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
                default:
                    Console.WriteLine("Please choose from ingridents listed");
                    break;

                    

            }

            return player.inventory.Lemons + player.inventory.Sugar + player.inventory.Cups + player.inventory.IceCubes; 
            //TODO: create day  

        }

        public int GetBuyLemons(Player player)
        {
            
            Console.WriteLine("Choose amount of Lemons to purchase: (10) = $1, (40) = $2, (65) = $3 OR (4) return to buying menu");
            int UserInput = Convert.ToInt32(Console.ReadLine());  

            if (UserInput == 10)
            {

                int AmountOfMoneyLeft = player.WalletAmount - UserInput;
                player.inventory.Lemons += UserInput;

                Console.WriteLine(AmountOfMoneyLeft);               
            }
            else if (UserInput == 40)
            {

                int AmountOfMoneyLeft = player.WalletAmount - UserInput;

                Console.WriteLine(AmountOfMoneyLeft);
            }
            else if (UserInput == 65)
            {

                int AmountOfMoneyLeft = player.WalletAmount - UserInput;

                Console.WriteLine(AmountOfMoneyLeft);
            }
            else if (UserInput == 4)
            {
                StoreItems(player);
            }
            else
            {
                Console.WriteLine("Please choose from the options given");
                GetBuyLemons(player);
            }
            Console.WriteLine(Lemons);
            return Lemons;

        }

        public int GetBuySugar(Player player)
        {
            Console.WriteLine("Choose amount of Sugar to purchase: 10 cups = $1.50, 35 cups = $2.50, 50 cups = $3.50");
            string UserInput = Console.ReadLine();

            if (UserInput == "")
            {
                int AmountOfMoneyLeft = player.WalletAmount - int.Parse(UserInput);

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
                int AmountOfMoneyLeft = player.WalletAmount - int.Parse(UserInput);

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
                int AmountOfMoneyLeft = player.WalletAmount - int.Parse(UserInput);

                Console.WriteLine(AmountOfMoneyLeft);
            }
            return IceCubes;
        }
       

        
    }
}