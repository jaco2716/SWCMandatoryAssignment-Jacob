using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using GameFramework.Charactor;
using GameFramework.Factories;
using GameFramework.Items;
using GameFramework.Obstacles;


namespace GameFramework
{
    public class Worker
    {
        private bool gameRunning = true;

        private List<Character> characters;
        private List<Obstacle> obstacles;
        private EnemyFactory EF = new EnemyFactory();
        private ObstacleFactory OF = new ObstacleFactory();
        
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
           
            obstacles = new List<Obstacle>();

            for (int i = 0; i < 25; i++)
            {
                obstacles.Add(OF.CreateObject());
            }
            
            RunGame();
        }
        public void RunGame()
        {

            while (gameRunning)
            {
                Console.Clear();

                Playground playground = new Playground();
                playground.MakePlayground();



                foreach (var item in obstacles)
                {
                    playground.cord[item.XPosition, item.YPosition] = item.Color;
                }
                List<Character> deadCharacters = new List<Character>();
                foreach (var item in characters)
                {
                    if (!item.IsDead)
                    {
                        playground.cord[item.XPosition, item.YPosition] = item.Color;
                        item.Act(playground.cord);
                        if (playground.cord[item.XPosition, item.YPosition] == Color.Yellow)
                        {
                            Chest chest = new Chest();
                            item.Item = chest.OpenChest(item);
                        }
                    }

                    if (item.IsDead)
                    {
                        deadCharacters.Add(item);
                    }
                }

                deadCharacters.ForEach(item => characters.Remove(item));

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
                Console.ReadKey();

            }

        }
    }
}
