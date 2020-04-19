using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using GameFramework.Items;

namespace GameFramework.Charactor
{
    class Wizard : Character
    {
        public Wizard(int xPosition, int yPosition, Weapon weapon) : base(xPosition, 40, CharacterKind.wizard,
            Color.Blue, yPosition, 12, weapon)
        {

        }

        public Wizard(int xPosition, int yPosition) : base(xPosition, 40, CharacterKind.wizard, Color.Blue, yPosition,
            12)
        {

        }
    }
}
