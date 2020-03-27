﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class Headlights : Equipment
    {
        public Headlights(string name, int cost) : base(name, cost) { }

        public override int DisplayCost() { return cost; }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + " -> Цена: " + DisplayCost());
        }
    }
}
