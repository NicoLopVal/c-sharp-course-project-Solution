using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Welcome : IActivities
    {
        public void Draw()
        {
            Console.WriteLine(@"╔╦╦╦═╦╗╔═╦═╦══╦═╗");
            Console.WriteLine(@"║║║║╩╣╚╣═╣║║║║║╩╣");
            Console.WriteLine(@"╚══╩═╩═╩═╩═╩╩╩╩═╝");
            Console.WriteLine(@"          {}");
            Console.WriteLine(@"         .--.");
            Console.WriteLine(@"        /.--.\");
            Console.WriteLine(@"        |====|");
            Console.WriteLine(@"        |`::`|");
            Console.WriteLine(@"    .-;`\..../`;_.-^-._");
            Console.WriteLine(@"   /  |...::..|`   :   `|");
            Console.WriteLine(@"  |   /'''::''|   .:.   |");
            Console.WriteLine(@"  ;--'\   ::  |..:::::..|");
            Console.WriteLine(@"  <__> >._::_.| ':::::' |");
            Console.WriteLine(@"  |  |/   ^^  |   ':'   |");
            Console.WriteLine(@"  \::/|       \    :    /");
            Console.WriteLine(@"  |||\|        \   :   /");
            Console.WriteLine(@"  ''' |___/\___|`-.:.-`");
            Console.WriteLine(@"       \_ || _/    `");
            Console.WriteLine(@"       <_ >< _>");
            Console.WriteLine(@"       |  ||  |");
            Console.WriteLine(@"       |  ||  |");
            Console.WriteLine(@"      _\.:||:./_");
            Console.WriteLine(@"     /____/\____\");
        }
    }
}
