using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using GameFramework.Charactor;
using GameFramework.Factories;
using GameFramework.Obstacles;


namespace GameFramework
{
    public class Worker
    {
        private bool gameRunning = true;

        private List<Character> characters;
        private List<Obstacle> obstacles;
        private EnemyFactory EF = new EnemyFactory();
        public void Start()
        {
            characters = new List<Character>();
            for (int i = 0; i < 100; i++)
            {
                characters.Add(EF.CreateObject());
            }


            // characters = new List<Character>
            // {
            //     new Knight(2,2),
            //     new Wizard(5, 2),
            //     new Skeleton(10, 3),
            //     new Knight(2,5),
            //     new Wizard(10, 5),
            //     new Skeleton(15, 5),
            //     new Knight(15,10),
            //     new Wizard(20, 10),
            //     new Skeleton(22, 10),
            //     new Knight(4,15),
            //     new Wizard(10, 15),
            //     new Skeleton(18, 15)
            // };
           
            obstacles = new List<Obstacle>
            {
                new Wall(11, 24),
                new Wall(11, 23),
                new Wall(11, 22),
                new Wall(11, 21),
                new Wall(15, 24),
                new Wall(15, 23),
                new Wall(15, 22),
                new Wall(15, 21),
                new ThornBush(5, 2),
                new ThornBush(24, 2),
                new ThornBush(20, 7),
                new ThornBush(19, 20),
                new ThornBush(15, 12),
                new ThornBush(6, 20)

            };
            
            RunGame();
        }
        public void RunGame()
        {

            while (gameRunning)
            {
                Console.Clear();

                Playground playground = new Playground();
                playground.MakePlayground();

                foreach (var item in characters)
                {
                    playground.cord[item.XPosition, item.YPosition] = item.Color;
                    item.Act();
                    if (playground.cord[item.XPosition, item.YPosition] == Color.Yellow)
                    {
                        item.Item = item.OpenChest();
                    }
                }

                foreach (var item in obstacles)
                {
                    playground.cord[item.XPosition, item.YPosition] = item.Color;
                }

                for (int i = 0; i < playground.YSize; i++)
                {
                    for (int j = 0; j < playground.XSize; j++)
                    {
                        Console.BackgroundColor =
                            (ConsoleColor) Enum.Parse(typeof(ConsoleColor), playground.cord[j, i].Name);
                        Console.Write("   ");
                    }

                    Console.WriteLine();
                }


                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("hej ");
                Console.ReadKey();

            }

        }
    }
}
