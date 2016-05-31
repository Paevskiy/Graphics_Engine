using System;
using System.Collections.Generic;
using Graphics_Engine;
using System.Threading;

namespace Graphics_engine
{

    class Program
    {
        
        public static object Engine { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("long time ago in a galaxy far,", ConsoleColor.DarkYellow, Console.CursorLeft = 15, Console.CursorTop = 10);
            Console.WriteLine("far away....", ConsoleColor.DarkYellow, Console.CursorLeft = 40, Console.CursorTop = 11);
            Thread.Sleep(1500);
            var shapes = new List<Shape>();
            shapes.Add(new StarWarsLogo(23, 6, ConsoleColor.Yellow));
            //shapes.Add(new AniStar(0, 0, ConsoleColor.Red, ConsoleColor.Yellow));
            //shapes.Add(new AniStar(20, 20, ConsoleColor.Green, ConsoleColor.White));
            EngineClass.Draw(shapes);
            Music.StarWars();
            EngineClass.Clean();
            Introduction.TetxOfIntroduction();
            Console.ReadKey();
            EngineClass.Clean();
            Console.WriteLine("The End",ConsoleColor.DarkYellow, Console.CursorLeft=35,Console.CursorTop=10);
            Console.ReadKey();
            //while (true)
            //{
            //    EngineClass.Draw(shapes);

            //}
        }
    }

   

    

    
}
