using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using GameFramework.Charactor;

namespace GameFramework.Obstacles
{
    class ThornBush : Obstacle
    {
        public ThornBush(int xPosition, int yPosition) : base(Color.DarkGreen, xPosition, yPosition)
        {
            Damage = 10;
        }
        public int Damage { get; set; }

        public void Attack(Character character)
        {
            character.Health -= Damage;
        }
    }
}
