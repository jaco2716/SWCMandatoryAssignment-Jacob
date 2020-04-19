using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GameFramework.Items
{
    class Shield : Item
    {
     

        public int DefenceValue { get; set; }


        public Shield(ItemType type, Color color) : base(type, color, 30)
        {
            DefenceValue = Value;
        }
    }
}
