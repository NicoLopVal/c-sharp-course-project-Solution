using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Goblin : ILivingBeing
    {
        public void Draw()
        {
            Console.WriteLine(@"             ,      ,           ");
            Console.WriteLine(@"            /(.-""-.)\			");
            Console.WriteLine(@"        |\  \/      \/  /|		");
            Console.WriteLine(@"        | \ / =.  .= \ / |		");
            Console.WriteLine(@"        \( \   o\/o   / )/		");
            Console.WriteLine(@"         \_, '-/  \-' ,_/		");
            Console.WriteLine(@"           /   \__/   \			");
            Console.WriteLine(@"           \ \__/\__/ /			");
            Console.WriteLine(@"         ___\ \|--|/ /___		");
            Console.WriteLine(@"       /`    \      /    `\		");
            Console.WriteLine(@"      /       '----'       \	");
        }
    }
}
