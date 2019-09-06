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

            Player player = new Player();

            Inventory inventory = new Inventory(store);

        

            player.StartingAmount(store);
        
            store.StoreItems(player);

         

            
            
        }
    }
}
