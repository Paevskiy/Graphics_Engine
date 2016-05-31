using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graphics_engine;

namespace Graphics_Engine
{
    class Star : Shape
    {

        public Star(int x, int y, ConsoleColor color)
            : base(x, y)
        {
            this.Color = color;
        }

        public ConsoleColor Color { get; set; }

        public override void Draw()
        {
            EngineClass.SetPixel(X + 1, Y + 0, this.Color);
            EngineClass.SetPixel(X + 2, Y + 1, this.Color);
            EngineClass.SetPixel(X + 0, Y + 1, this.Color);
            EngineClass.SetPixel(X + 1, Y + 2, this.Color);
        }
    }
}
