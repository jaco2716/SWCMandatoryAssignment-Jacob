using System;
using System.Collections.Generic;
using System.Text;
using GameFramework.Charactor;
using GameFramework.Items;
using GameFramework.Obstacles;

namespace GameFramework.Factories
{
    class ObstacleFactory
    {
        Random random = new Random();
        public Obstacle CreateObject()
        {
            int posX = RandomPosition(0, 25);
            int posY = RandomPosition(0, 25);

            int obstacletype = random.Next(0, 3);

            switch (obstacletype)
            {
                case 0:
                    return new Chest(posX, posY);
                case 1:
                    return new ThornBush(posX, posY);
                default:
                    return new Wall(posX, posY);

            }
        }

        public int RandomPosition(int minValue, int maxValue)
        {
            int value = random.Next(minValue, maxValue);
            return value;
        }
    }
}
