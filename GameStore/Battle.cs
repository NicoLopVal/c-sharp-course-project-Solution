using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Battle : IActivities
    {
        public void Draw()
        {
            Console.WriteLine(@"                           .-.      ");
            Console.WriteLine(@"                          {{#}} 	");
            Console.WriteLine(@"          {}               8@8		");
            Console.WriteLine(@"        .::::.             888		");
            Console.WriteLine(@"    @\\/W\/\/W\//@         8@8		");
            Console.WriteLine(@"     \\/^\/\/^\//     _    )8(    _	");
            Console.WriteLine(@"      \_O_{}_O_/     (@)__/8@8\__(@)");
            Console.WriteLine(@" ____________________ `~ -=):(= -~` ");
            Console.WriteLine(@"|<><><>  |  |  <><><>|     |.|		");
            Console.WriteLine(@"|<>      |  |      <>|     |S|		");
            Console.WriteLine(@"|<>      |  |      <>|     |'|		");
            Console.WriteLine(@"|<>   .--------.   <>|     |.|		");
            Console.WriteLine(@"|     |   ()   |     |     |P|		");
            Console.WriteLine(@"|_____| (O\/O) |_____|     |'|		");
            Console.WriteLine(@"|     \   /\   /     |     |.|		");
            Console.WriteLine(@"|------\  \/  /------|     |U|		");
            Console.WriteLine(@"|       '.__.'       |     |'|		");
            Console.WriteLine(@"|        |  |        |     |.|		");
            Console.WriteLine(@":        |  |        :     |N|		");
            Console.WriteLine(@" \       |  |       /      |'|		");
            Console.WriteLine(@"  \<>    |  |    <>/       |.|		");
            Console.WriteLine(@"   \<>   |  |   <>/        |K|		");
            Console.WriteLine(@"    `\<> |  | <>/'         |'|		");
            Console.WriteLine(@"      `-.|__|.-`           \ /		");
            Console.WriteLine(@"                            ^		");
        }
    }
}
