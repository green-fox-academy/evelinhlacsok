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
        public void ListOfIntegersTest_withMultipleElements()
        {
            //arrange
            List<int> inputList = new List<int> { 1, 2, 3, 4 };

            //act
            int output = 10;

            //assert
            Assert.AreEqual(output, myOriginal.ListOfIntegers(inputList));
        }

        [Test]
        public void ListOfIntegersTest_withEmptyList ()
        {
            List<int> inputList2 = new List<int> { };
            int output2 = 0;
            Assert.AreEqual(output2, myOriginal.ListOfIntegers(inputList2));
        }

        [Test]
        public void ListOfIntegersTest_with1Element ()
        {
            List<int> inputList3 = new List<int> { 3 };
            int output3 = 3;
            Assert.AreEqual(output3, myOriginal.ListOfIntegers(inputList3));
        }

        [Test]
        public void ListOfIntegersTest_withNull ()
        {
            List<int> inputList4 = null;
            int output4 = 0;
            Assert.AreEqual(output4, myOriginal.ListOfIntegers(inputList4));
        }
       
    }
}
