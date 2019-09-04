using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class LemonadeGame
    {
        int Player;
        string Store;
        string DisplayGameRules;

        
        public LemonadeGame()
        {
        


        }


        public void GameRules()
        {
            Console.WriteLine("You have 7 days to make as much money as possible from your Lemonade Stand, these days will have weather conditions.\nSo keep in mind your inventory and sale price should be based off of the weather for that day. Not all customer will\npurchase lemonade, so you do have control over your inventory, ingredients, and sale price of your lemonade. You have a starting amount of $25.00");
            Console.ReadLine();
        }
    }
}