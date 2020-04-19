using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GameFramework.Obstacles
{
    class ThornBush : Obstacle
    {
        public ThornBush(int xPosition, int yPosition) : base(Color.DarkGreen, xPosition, yPosition)
        {
            Damage = 7;
        }
        public int Damage { get; set; }

        public void Attack()
        {
       
        }
    }
}
