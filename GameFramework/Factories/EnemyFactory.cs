using System;
using System.Collections.Generic;
using System.Text;
using GameFramework.Charactor;

namespace GameFramework.Factories
{
    public class EnemyFactory
    {
        Random random = new Random();
        public Character CreateObject()
        {
            int posX = RandomPosition(0, 25);
            int posY = RandomPosition(0, 25);

            int enemytype = random.Next(0, 3);

            switch (enemytype)
            {
                case 0: 
                    return new Knight(posX, posY);
                case 1:
                    return new Skeleton(posX, posY);
                default:
                    return new Wizard(posX, posY);

            }
        }

        public int RandomPosition(int minValue, int maxValue)
        {
            int value = random.Next(minValue, maxValue);
            return value;
        }
    }
}
