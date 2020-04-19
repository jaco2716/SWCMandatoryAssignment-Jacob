using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GameFramework.Items
{
    public abstract class Item
    {
        public Item(ItemType type, Color color, int value)
        {
            Type = type;
            Color = color;
            Value = value;
        }

        public ItemType Type { get; set; }
        public Color Color { get; set; }
        public int Value { get; set; }

    }
}
