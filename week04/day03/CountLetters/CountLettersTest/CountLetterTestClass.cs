using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountLetters;
using NUnit.Framework;

namespace CountLettersTest
{
    [TestFixture]
    public class CountLetterTestClass
    {
        CountLetterClass myOriginal = new CountLetterClass();

        [Test]
        public void DictonaryTester ()
        {
            Dictionary<char, int> output = new Dictionary<char, int>()
            {
                {'c', 2 },
                {'a', 1 },
                {'t', 1 },
                {'u', 1 },
                {'s', 1 }

            };
            Assert.AreEqual(output, myOriginal.MyLetterCounter("cactus"));
        }
    }
}
