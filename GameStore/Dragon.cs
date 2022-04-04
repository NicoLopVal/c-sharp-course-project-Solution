using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    //A class implements an Interface
    public class Dragon : ILivingBeing
    {
        public void Draw()
        {
            Console.WriteLine(@"       ,===:'.,            `-._              ");
            Console.WriteLine(@"            `:.`---.__         `-._          ");
            Console.WriteLine(@"              `:.     `--.         `.        ");
            Console.WriteLine(@"                \.        `.         `.      ");
            Console.WriteLine(@"        (,,(,    \.         `.   ____,-`.,   ");
            Console.WriteLine(@"     (,'     `/   \.   ,--.___`.'            ");
            Console.WriteLine(@" ,  ,'  ,--.  `,   \.;'         `            ");
            Console.WriteLine(@"  `{D, {    \  :    \;                       ");
            Console.WriteLine(@"    V,,'    /  /    //                       ");
            Console.WriteLine(@"    j;;    /  ,' ,-//.    ,---.      ,       ");
            Console.WriteLine(@"    \|'   /  ,' /  _  \  /  _  \   ,'/       ");
            Console.WriteLine(@"          \  `'  / \  `'  / \  `.' /         ");
            Console.WriteLine(@"           `.___,'   `.__,'   `.__,'         ");
        }
    }
}
