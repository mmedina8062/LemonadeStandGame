using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class LemonadeGame
    {
        string Player;
        string Store;
        string GameRules;
    }

    public void GameRules()
    {
        Console.WriteLine("You have 7 days to make as much money as possible from your Lemonade Stand.\n");
        Console.WriteLine("These days will have weather conditions, so keep in mind you inventory and sale price should be based off of the weather for that days.\n");
        Console.WriteLine("You do have control over your inventory, ingredients, and sale price of your lemonade.\n");
        
    }
}