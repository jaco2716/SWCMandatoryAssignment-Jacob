using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using GameFramework.Items;

namespace GameFramework.Charactor
{
    public abstract class Character
    {
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



        public virtual void Act()
        {
            Move();
        }

        public void Move()
        {
            Random random = new Random();
            int direction = random.Next(0, 5);

            switch (direction)
            {
                case 0:
                    if (XPosition > 0)
                    {
                        XPosition -= 1;
                    }
                    break;
                case 1:
                    if (XPosition < 24)
                    {
                        XPosition += 1;
                    }
                    break;
                case 2:
                    if (YPosition > 0)
                    {
                        YPosition -= 1;
                    }
                    break;
                case 3:
                    if (YPosition < 24)
                    {
                        YPosition += 1;
                    }
                    break;
                default:
                    break;
            }
        }


    }
}
