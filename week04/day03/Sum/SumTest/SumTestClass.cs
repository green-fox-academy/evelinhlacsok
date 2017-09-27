using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sum;
using NUnit.Framework;

namespace SumTest
{
    [TestFixture]
    public class SumTestClass
    {
        SumClass myOriginal = new SumClass();

        [Test]
        public void ListOfIntegersTest()
        {
            //arrange
            List<int> inputList = new List<int> { 1, 2, 3, 4 };

            //act
            int output = 10;

            //assert
            Assert.AreEqual(output, myOriginal.ListOfIntegers(inputList));
        }

       
    }
}
