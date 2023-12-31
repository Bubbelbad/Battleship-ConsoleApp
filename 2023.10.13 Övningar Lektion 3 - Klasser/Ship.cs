﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._13_Sänka_Skepp
{
    internal class Ship : IShip
    {
        public string Name { get; set; }
        public int XCoordinate { get; }
        public int Size { get; }
        public bool ShipAlive { get; }

        static Random rnd = new Random();

        int randomY = rnd.Next(1, 11);


        public Ship(string name, int size)
        {
            this.Name = name;
            this.XCoordinate = randomY;
            this.Size = size;
            this.ShipAlive = true;
        }
    }
}
