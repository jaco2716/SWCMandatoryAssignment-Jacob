using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework.Items
{
    class Weapons : Item
    {
        public int Range { get; set; }

        public Weapons(ItemType type, int value, int range) : base(type, value)
        {
            Range = range;
        }

        public virtual int GetDamage()
        {
            throw new NotImplementedException();
        }
    }
}
