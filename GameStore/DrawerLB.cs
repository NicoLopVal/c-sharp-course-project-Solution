using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    public class DrawerLB
    {
        public void Draw(ILivingBeing livingBeing)
        {
            livingBeing.Draw();
        }
    }
}
