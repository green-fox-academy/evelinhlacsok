using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden2
{
    class Tree : Plant
    {
        public Tree(string color)
        {
            this.color = color;
            waterNeed = 10;
            waterAbsorb = 0.4;
            type = "tree";
        }
    }
}
