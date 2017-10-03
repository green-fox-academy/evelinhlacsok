using System;
using System.Globalization;

namespace TheGardenApplication
{
    public class Flowers : Plant
    {
        public Flowers()
        {
            string flower1;
            string flower2;
            
            base.color = colors[0];
            waterNeed = 0.75;
        }
    }
}