using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Golem : ILivingBeing
    {
        public void Draw()
        {
            Console.WriteLine(@"           ___                      ");
            Console.WriteLine(@"         .';:;'.					");
            Console.WriteLine(@"        /_' _' /\   __				");
            Console.WriteLine(@"        ;a/ e= J/-''  '.			");
            Console.WriteLine(@"        \ ~_   (  -'  ( ;_ ,.		");
            Console.WriteLine(@"         L~''_.    -.  \ ./  )		");
            Console.WriteLine(@"         ,'-' '-._  _;  )'   (		");
            Console.WriteLine(@"       .' .'   _.'')  \  \(  |      ");
            Console.WriteLine(@"      /  (  .-'   __\{`', \  |		");
            Console.WriteLine(@"     / .'  /  _.-'   '  . /  |      ");
            Console.WriteLine(@"    / /    '-._'-,     / / \ (		");
            Console.WriteLine(@" __/ (_    ,;' .-'    / /  /_'-._	");
            Console.WriteLine(@"`' - '` ~`  ccc.'   __.','     \j\L\");
            Console.WriteLine(@"                 .='/|\7      		");
            Console.WriteLine(@"     	           ' `				");
        }
    }
}
