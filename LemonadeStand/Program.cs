using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            LemonadeGame lemonadeGame = new LemonadeGame();
            lemonadeGame.GameRules();

            Store store = new Store();
            store.PriceOfItems();
         

            Player player = new Player();
            Console.WriteLine("Money: " + player.StartingAmount);
            Console.ReadLine();
            
            
        }
    }
}
