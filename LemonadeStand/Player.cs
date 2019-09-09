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
            //this.startingAmount = 25.ToString("C"); //change string to int



        }



        //public int Wallet()
        //{
            //string StartingAmount = 25.ToString("C");
            //Console.WriteLine(StartingAmount);

        //}
        public void RecipeAndPrice()
        {
            string[] ingridents = new string[] { "Lemons", "Sugar", "Ice Cubes", "Cups" };

            for (int i = 0; i <= ingridents.Length; i++)
            {
                if (ingridents[i] == "Lemons")
                {
                    Console.WriteLine("Enter amount of Lemons per pitcher: ");
                    string UserInput = Console.ReadLine();
                    
                }
                else if (ingridents[i] == "Sugar")
                {
                    Console.WriteLine("Enter amount of Sugar per pitcher: ");
                    string UserInput = Console.ReadLine();
                    
                }
                else if (ingridents[i] == "Ice Cubes")
                {
                    Console.WriteLine("Enter amount of Ice Cubes per Cup: ");
                    string UserInput = Console.ReadLine();

                }
                else if (ingridents[i] == "Cups")
                {
                    Console.WriteLine("Enter price per Cup: ");
                    string UserInput = Console.ReadLine();

                }
            }
            

            //TODO: create a calculator to subtract amount customer purchase from inventory
            
            //Console.WriteLine("Amount of Lemons: ");
            //string UserInput = Console.ReadLine();

           // if (UserInput == "")
            //{
                //Console.WriteLine(inventory.Lemons - int.Parse(UserInput));

            //}

            

            

        }
    }
}