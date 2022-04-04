using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Elf : ILivingBeing
    {
        public void Draw()
        {
            Console.WriteLine(@"           .-----.   ");
            Console.WriteLine(@" \ ' /   _/    )/	 ");
            Console.WriteLine(@"- ( ) -('---''--)	 ");
            Console.WriteLine(@" / . \((()\^_^/)()	 ");
            Console.WriteLine(@"  \\_\ (()_)-((()()	 ");
            Console.WriteLine(@"   '- \ )/\._./(()	 ");
            Console.WriteLine(@"     '/\/( X   ) \	 ");
            Console.WriteLine(@"     (___)|___/ ) \	 ");
            Console.WriteLine(@"          |.#_|(___) ");
            Console.WriteLine(@"         /\    \ ( (_");
            Console.WriteLine(@"         \/\/\/\) \\ ");
            Console.WriteLine(@"        | / \ |      ");
            Console.WriteLine(@"         |(   \|	 ");
            Console.WriteLine(@"        _|_)__|_\_	 ");
            Console.WriteLine(@"        )...()...(	 ");
            Console.WriteLine(@"         | (   \ |   ");
            Console.WriteLine(@"      .-'__,)  (  \	 ");
            Console.WriteLine(@"               '\_-, ");
        }
    }
}
