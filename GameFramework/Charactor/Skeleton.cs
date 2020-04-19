using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using GameFramework.Items;

namespace GameFramework.Charactor
{
    class Skeleton : Character
    {
        public Skeleton(int xPosition, int yPosition, Weapon weapon) : base(xPosition, 30, CharacterKind.skeleton, Color.Gray, yPosition, 15, weapon)
        {
            
        }
        public Skeleton(int xPosition, int yPosition) : base(xPosition, 30, CharacterKind.skeleton, Color.Gray, yPosition, 15)
        {

        }


    }
}
