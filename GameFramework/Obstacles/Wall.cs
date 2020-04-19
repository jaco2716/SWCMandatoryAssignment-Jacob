using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GameFramework.Obstacles
{
    class Wall : Obstacle
    {
        public Wall(int xPosition, int yPosition) : base(Color.Black, xPosition, yPosition)
        {

        }
    }
}
