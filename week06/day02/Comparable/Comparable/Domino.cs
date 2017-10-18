using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparable
{
    public class Domino : IComparable<Domino>
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return Values;
        }
       
        public string GetDominoString()
        {
            return $"[{Values[0]}, {Values[1]}]";
        }

        public int CompareTo(Domino that)
        {
            if (this.Values[0] > that.Values[0])
            {
                return 1;
            }
            if (this.Values[0] == that.Values[0])
            {
                return 0;
            }
            return -1;
        }
    }
}
