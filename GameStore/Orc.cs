using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Orc : ILivingBeing
    {
        public void Draw()
        {
            Console.WriteLine(@"         _......._               ");
            Console.WriteLine(@"       .-'.'.'.'.'.'.`-.		 ");
            Console.WriteLine(@"     .'.'.'.'.'.'.'.'.'.`.		 ");
            Console.WriteLine(@"    /.'.'               '.\		 ");
            Console.WriteLine(@"    |.'    _.--...--._     |	 ");
            Console.WriteLine(@"    \    `._.-.....-._.'   /	 ");
            Console.WriteLine(@"    |     _..- .-. -.._   |		 ");
            Console.WriteLine(@" .-.'    `.   ((@))  .'   '.-.	 ");
            Console.WriteLine(@"( ^ \      `--.   .-'     / ^ )	 ");
            Console.WriteLine(@" \  /         .   .       \  /	 ");
            Console.WriteLine(@" /          .'     '.  .-    \	 ");
            Console.WriteLine(@"( _.\    \ (_`-._.-'_)    /._\)  ");
            Console.WriteLine(@" `-' \   ' .--.          / `-'	 ");
            Console.WriteLine(@"     |  / /|_| `-._.'\   |       ");
            Console.WriteLine(@"     |   |       |_| |   /-.._   ");
            Console.WriteLine(@" _..-\   `.--.______.'  |		 ");
            Console.WriteLine(@"      \       .....     |        ");
            Console.WriteLine(@"       `.  .'      `.  /		 ");
            Console.WriteLine(@"         \           .'          ");
            Console.WriteLine(@"          `-..___..-`			 ");
        }
    }
}
