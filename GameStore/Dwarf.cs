using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Dwarf : ILivingBeing
    {
        public void Draw()
        {
            Console.WriteLine(@"                        __.--|~|--.__                               ,,;/;    ");
            Console.WriteLine(@"                         /~     | |    ;~\                        ,;;;/;;'	 ");
            Console.WriteLine(@"                        /|      | |    ;~\\                     ,;;;;/;;;'	 ");
            Console.WriteLine(@"                       |/|      \_/   ;;;|\                    ,;;;;/;;;;'   ");
            Console.WriteLine(@"                       |/ \          ;;;/  )                 ,;;;;/;;;;;'    ");
            Console.WriteLine(@"                   ___ | ______     ;_____ |___....__      ,;;;;/;;;;;'      ");
            Console.WriteLine(@"             ___.-~ \\(| \  \.\ \__/ /./ /:|)~   ~   \   ,;;;;/;;;;;'        ");
            Console.WriteLine(@"         /~~~    ~\    |  ~-.     |   .-~: |//  _.-~~--,;;;;/;;;;;'          ");
            Console.WriteLine(@"        (.-~___     \.'|    | /-.__.-\|::::| //~     ,;;;;/;;;;;'  			 ");
            Console.WriteLine(@"        /      ~~--._ \|   /          `\:: |/      ,;;;;/;;;;;'				 ");
            Console.WriteLine(@"     .-|             ~~|   |  /V""""V\ |:  |     ,;;;;/;;;;;' \				 ");
            Console.WriteLine(@"    /                   \  |  ~`^~~^'~ |  /    ,;;;;/;;;;;'    ;			 ");
            Console.WriteLine(@"   (        \             \|`\._____./'|/    ,;;;;/;;;;;'      '\			 ");
            Console.WriteLine(@"  / \        \                             ,;;;;/;;;;;'     /    |			 ");
        }
    }
}
