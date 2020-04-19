using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GameFramework.Items
{
    class Bow : Weapon
    {
        public Bow(ItemType type, Color color) : base(type, color, 15, 2)
        {

        }
    }
}
