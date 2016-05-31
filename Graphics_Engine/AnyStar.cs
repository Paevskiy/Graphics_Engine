using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graphics_engine;

namespace Graphics_Engine
{
        class AniStar : Star
        {
            public AniStar(int x, int y, ConsoleColor color1, ConsoleColor color2)
                : base(x, y, color1)
            {
                this.color1 = color1;
                this.color2 = color2;
            }
            public override void Draw()
            {
                this.Color = (this.i++) % 2 == 0 ? this.color1 : this.color2;
                base.Draw();
            }
            private int i = 0;
            private ConsoleColor color1;
            private ConsoleColor color2;
        }
    
}
