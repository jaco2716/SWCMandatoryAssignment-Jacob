using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GameFramework.Items
{
    public abstract class Weapon : Item
    {
        
        public int ExtraDamage { get; set; }
        public int Range { get; set; }


        protected Weapon(ItemType type, Color color, int value, int range) : base(type, color, value)
        {
            ExtraDamage = value;
            Range = range;
        }
    }
}
