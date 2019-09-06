using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Inventory
    {
        public int Lemons;
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
            this.Lemons = 0;
            this.Sugar = 0;
            this.Cups = 0;
            this.IceCubes = 0;

        } 
    }
}