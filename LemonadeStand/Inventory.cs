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
            this.Sugar = 0;
            this.Cups = 0;
            this.IceCubes = 0;

        }
        //public int PlayerInventory(int Lemon, int Sugar, int Cups, int IceCubes)
        //{
            //create a list and add int to it?
            //string[] PlayerInventory = new string[4] { "Lemon", "Sugar", "Cups", "Ice Cubes" };
            //Console.WriteLine(Lemon += );
       
            
            
            
        
    }
}