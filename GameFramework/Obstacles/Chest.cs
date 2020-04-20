using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using GameFramework.Charactor;
using GameFramework.Items;

namespace GameFramework.Obstacles
{
    class Chest : Obstacle
    {
        Random random = new Random();
        public Chest(int xPosition, int yPosition) : base(Color.Yellow, xPosition, yPosition)
        {

        }

        public Chest()
        {
            
        }

        public Item OpenChest(Character character)
        {
            if (character.Item == null)
            {
                int itemIndex = random.Next(3);

                switch (itemIndex)
                {
                    case 0:
                        return new Bow();
                    case 1:
                        return new Sword();
                    default:
                        return new Shield();
                }
            }
            else
            {
                return ItemDecorator.GetDamage(character.Item);
            }
        }
    }
}
