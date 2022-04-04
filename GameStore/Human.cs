using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Human : ILivingBeing
    {
        public void Draw()
        {
            Console.WriteLine(@"       .-""-.		");
            Console.WriteLine(@"      /-.{}  \ 		");
            Console.WriteLine(@"      | _\__.|		");
            Console.WriteLine(@"      \/^)^ \/		");
            Console.WriteLine(@"       \ =  /		");
            Console.WriteLine(@"  .---./`--`\.--._	");
            Console.WriteLine(@" /     `;--'`     \	");
            Console.WriteLine(@";        /`       ;	");
            Console.WriteLine(@"|       |*        | ");
            Console.WriteLine(@"/   |   |     |    \");
            Console.WriteLine(@"|    \  |*    /    |");
            Console.WriteLine(@"\_   |\_|____/|  __/");
            Console.WriteLine(@"  \__//======\\__/	");
            Console.WriteLine(@"  / //_      _\\ \	");
            Console.WriteLine(@"  -'  |`""""`|  `-	");
            Console.WriteLine(@"      |  L   |		");
            Console.WriteLine(@"      >_ || _<		");
            Console.WriteLine(@"      |  ||  |		");
            Console.WriteLine(@"      |  ||  |		");
            Console.WriteLine(@"     /   ||   \		");
            Console.WriteLine(@"    /    /,    \	");
            Console.WriteLine(@"    `|' |`'|' |''`  ");
            Console.WriteLine(@"     /  )  /  )  	");
            Console.WriteLine(@"    /__/  /__/		");
        }
    }
}
