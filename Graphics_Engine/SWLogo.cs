using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics_Engine
{
    class StarWarsLogo: Shape
    {
        public StarWarsLogo(int x, int y, ConsoleColor color)
            : base(x, y)
        {
            this.Color = color;
        }

        public ConsoleColor Color { get; set; }

        public override void Draw()
        {
            int[][] line = new int[12][]; // объявляем массив, который содержит 12 массивов
            // первая строка
            line[0] = new int[] {4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 17, 18, 19, 24, 25, 26,27, 28 };
            line[1] = new int[] {3,4,11,12,16,17,19,20,24,25,28,29};
            line[2] = new int[] {4,5,6,7,11,12,15,16,20,21,24,25,26,27,28};
            line[3] = new int[] {7,8,11,12,14,15,16,17,18,19,20,21,22,24,25,28,29};
            line[4] = new int[] {0,1,2,3,4,5,6,7,11,12,14,15,21,22,24,25,29,30,31,32,33,34};
            // пустные стоки
            line[5] = new int[0];
            line[6] = new int[0];
            // вторая  строка
            line[7] = new int[] { 0, 1, 4, 5, 8, 9, 13, 14, 20, 21, 22, 23, 24, 29, 30, 31, 32, 33, 34 };
            line[8] = new int[] { 0, 1, 4, 5, 8, 9, 12, 13, 15, 16, 20, 21, 24, 25, 28, 29 };
            line[9] = new int[] { 0, 1, 3, 4, 5, 6, 8, 9, 11, 12, 16, 17, 20, 21, 22, 23, 24, 29, 30, 31, 32 };
            line[10] = new int[] { 1, 2, 3, 6, 7, 8, 10, 11, 12, 13, 14, 15, 16, 17, 18, 20, 21, 24, 25, 32, 33 };
            line[11] = new int[] { 2, 3, 6, 7, 10, 11, 17, 18, 20, 21, 25, 26, 27, 28, 29, 30, 31, 32 };

            for (int i = 0; i < 12; i++)
            {
                foreach (int t in line[i])
                {
                    EngineClass.SetPixel(X + t, Y + i, this.Color);
                }
            }
        }
    }
}
