using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Inventory
    {
        public int Lemon;
        public int Sugar;
        public int Cups;
        public int IceCubes;
        public Player Player
        {
            get => default;
            set
            {
            }
        }

        public Inventory()
        {
            this.Lemon = 0;

        }

        public string PlayerInventory(int Lemon, int Sugar, int Cups, int IceCubes)
        {
            //string[] PlayerInventory = new string[4] { "Lemon", "Sugar", "Cups", "Ice Cubes" };
            
        }
    }
}