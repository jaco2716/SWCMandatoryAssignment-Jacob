using System;
using System.ComponentModel;
using GameFramework;

namespace GameRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.Start();


            Console.ReadKey();
        }
    }
}
