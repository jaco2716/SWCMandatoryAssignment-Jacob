using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using GameFramework.Items;

namespace GameFramework.Obstacles
{
    class Chest : Obstacle
    {
        public Chest(int xPosition, int yPosition, Item chestItem) : base(Color.Yellow, xPosition, yPosition)
        {

        }


    }
}
