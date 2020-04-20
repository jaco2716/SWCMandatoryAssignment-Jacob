using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using GameFramework.Charactor;
using GameFramework.Items;

namespace GameFramework
{
    static class ItemDecorator
    {
        public static Item GetDamage(Item item, double decor = 1.3)
        {
            Debug.WriteLine(item.Value);

            item.Value = (int)Math.Round(item.Value * decor);
            Debug.WriteLine(item.Value);
            return item;
        }
    }
}
