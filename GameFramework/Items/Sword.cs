using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GameFramework.Items
{
    class Sword : Weapon
    {

        public Sword(ItemType type, Color color) : base(type, color, 30, 1)
        {

        }
    }
}
