using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Market : IActivities
    {
        public void Draw()
        {
            Console.WriteLine(@"          __-----__				");
            Console.WriteLine(@"     ..;;;--'~~~`--;;;..		");
            Console.WriteLine(@"   /;-~  GAME MARKET  ~-.\		");
            Console.WriteLine(@"  //      ,;;;;;;;;      \\		");
            Console.WriteLine(@".//      ;;;;;    \       \\	");
            Console.WriteLine(@"||       ;;;;(   /.|       ||	");
            Console.WriteLine(@"||       ;;;;;;;   _\      ||	");
            Console.WriteLine(@"||       ';;  ;;;;=        ||	");
            Console.WriteLine(@"||         | ''\;;;;;;     ||	");
            Console.WriteLine(@" \\     ,| '\  '|><|      //	");
            Console.WriteLine(@"  \\   |     |      \    //		");
            Console.WriteLine(@"   `;.,|.    |      '\.-'/		");
            Console.WriteLine(@"    ~~;;;,._|___.,-;;;~'		");
            Console.WriteLine(@"        ''=--'					");
        }
    }
}
