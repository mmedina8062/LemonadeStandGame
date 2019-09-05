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

            Player player = new Player();

            Store store = new Store();
            
            store.GetBuyLemons(player);

            store.StoreItems(player);

         

            
            
        }
    }
}
