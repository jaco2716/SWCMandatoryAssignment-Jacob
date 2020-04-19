﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework.Items
{
    class Weapon : Item
    {
        public int Range { get; set; }

        public Weapon(ItemType type, int value, int range) : base(type, value)
        {
            Range = range;
        }
    }
}
