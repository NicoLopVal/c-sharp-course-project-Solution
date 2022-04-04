using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class Training : IActivities
    {
        public void Draw()
        {
            Console.WriteLine(@"                  TRAINING MODE				    ");
            Console.WriteLine(@"                        |					    ");
            Console.WriteLine(@"        _            \    /             _		");
            Console.WriteLine(@"      _|#|       .-.         .-.       |#|_		");
            Console.WriteLine(@"     |#|#|______/  /_ .-'-. _\  \______|#|#|	");
            Console.WriteLine(@"    [|#|#|------| (  || | ||  ) |------|#|#|]	");
            Console.WriteLine(@"     |#|#|      |__|_.-'''-._|__|    Pr|#|#|	");
            Console.WriteLine(@"        |#|                           59|#| 	");
            Console.WriteLine(@"        ''                               ''		");
        }
    }
}
