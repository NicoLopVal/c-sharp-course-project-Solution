using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
     public class Drawer
     {
        public static void Draw(string[] drawing)
        {
            foreach (var line in drawing)
                Console.WriteLine(line);
        }
     }
}
