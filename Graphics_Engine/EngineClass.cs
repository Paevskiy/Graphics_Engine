using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Graphics_Engine
{
    static class EngineClass
    {
        public static object Engine { get; private set; }

        public static void Clean()
        {
            Console.Clear();
        }

        public static void SetPixel(int x, int y, ConsoleColor color = ConsoleColor.White)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write("█");
        }

        public static void Draw(List<Shape> shapes)
        {
            EngineClass.Clean();
            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            Thread.Sleep(100);
        }
    }
}
