using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GameFramework
{
    class Playground
    {
        public Color[,] cord { get; set; }
        public int XSize { get; }
        public int YSize { get; }

        public Playground()
        {
            XSize = 25;
            YSize = 25;
            cord = new Color[XSize, YSize];
        }

        public bool MakePlayground()
        {
            for (int i = 0; i < YSize; i++)
            {
                for (int j = 0; j < XSize; j++)
                {
                    cord[j, i] = Color.White;

                }
            }

            return true;
        }
    }
}
