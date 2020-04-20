using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using GameFramework.Items;

namespace GameFramework.Charactor
{
    class Knight : Character
    {
        public Knight(int xPosition, int yPosition, Weapons weapon) : base(xPosition, 50, CharacterKind.knight, Color.Cyan, yPosition, 18, weapon)
        {

        }
        public Knight(int xPosition, int yPosition) : base(xPosition, 50, CharacterKind.knight, Color.Cyan, yPosition, 18)
        {

        }

    }
}
