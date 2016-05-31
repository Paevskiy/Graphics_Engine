using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics_Engine
{
    class Introduction
    {
        public static void TetxOfIntroduction()
        {
// думаю над стилем, как отработать медленное движение.
// Созда массив строк (текст)
// создаю область прокрутки из 10 строк (так же строковый массив, с динамически перезаписываемыми строками)
// вывожу на экран
            Console.WriteLine(@"
Episode IV
A NEW HOPE
It is a period of civil war.
Rebel spaceships, striking
from a hidden base, have won
their first victory against
the evil Galactic Empire.

During the battle, Rebel
spies managed to steal secret
plans to the Empire's
ultimate weapon, the DEATH
STAR, an armored space
station with enough power
to destroy an entire planet.

Pursued by the Empire's
sinister agents, Princess
Leia races home aboard her
starship, custodian of the
stolen plans that can save her
people and restore
freedom to the galaxy....
", ConsoleColor.DarkYellow);

        }
    }
}
