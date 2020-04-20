using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GameFramework.Obstacles
{
    abstract class Obstacle
    {
        protected Obstacle(Color color, int xPosition, int yPosition)
        {
            Color = color;
            XPosition = xPosition;
            YPosition = yPosition;
        }

        public Obstacle()
        {
            
        }

        public Color Color { get; set; }
        public ObstacleType Type { get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }

    }
}
