using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sum
{
    public class SumClass
    {

        public int ListOfIntegers(List<int> inputList)
        {
            if (inputList == null)
            {
                return 0;
            }
            return inputList.Sum();
        }
    }
}
