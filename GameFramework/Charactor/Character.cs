using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using GameFramework.Items;

namespace GameFramework.Charactor
{
    public abstract class Character
    {
        Random random = new Random();

        protected Character(int xPosition, int health, CharacterKind kind, Color color, int yPosition, int damage, Item item)
        {
            XPosition = xPosition;
            Health = health;
            Kind = kind;
            Color = color;
            YPosition = yPosition;
            Damage = damage;
            Item = item;
        }
        protected Character(int xPosition, int health, CharacterKind kind, Color color, int yPosition, int damage)
        {
            XPosition = xPosition;
            Health = health;
            Kind = kind;
            Color = color;
            YPosition = yPosition;
            Damage = damage;
        }

        public CharacterKind Kind { get; }

        public int XPosition { get; set; }

        public int YPosition { get; set; }

        public int Health { get; set; }

        public Color Color { get; set; }

        public int Damage { get; set; }

        public Item Item { get; set; }

        public bool IsDead => Health <= 0;



        public virtual void Act(Color[,] playground)
        {
            Move(playground);
        }

        

        public virtual void Move(Color[,] playground)
        {
            int direction = random.Next(5);

            switch (direction)
            {
                case 0:
                    if (XPosition > 0 && playground[XPosition -1,YPosition] != Color.Black)
                    {
                        XPosition -= 1;
                    }
                    break;
                case 1:
                    if (XPosition < 24 && playground[XPosition + 1, YPosition] != Color.Black)
                    {
                        XPosition += 1;
                    }
                    break;
                case 2:
                    if (YPosition > 0 && playground[XPosition, YPosition - 1 ] != Color.Black)
                    {
                        YPosition -= 1;
                    }
                    break;
                case 3:
                    if (YPosition < 24 && playground[XPosition, YPosition + 1] != Color.Black)
                    {
                        YPosition += 1;
                    }
                    break;
            }
        }


    }
}
