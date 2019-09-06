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

        public Inventory(Store store)
        {
            this.Lemons = 0 + store.Lemons;
            this.Sugar = 0 + store.Sugar;
            this.Cups = 0 + store.Cups;
            this.IceCubes = 0 + store.IceCubes;

        }
        //public int PlayerInventory(int Lemon, int Sugar, int Cups, int IceCubes)
        //{
            //create a list and add int to it?
            //string[] PlayerInventory = new string[4] { "Lemon", "Sugar", "Cups", "Ice Cubes" };
            //Console.WriteLine(Lemon += );
       
       //public int BoughtInventory(Player inventory)
        //{
            
        //}
            
            
            
        
    }
}