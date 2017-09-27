using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anagram;
using NUnit.Framework;

namespace AnagramTest
{
    [TestFixture]
    public class AnagramTestClass
    {
        AnagramClass myOriginal = new AnagramClass();

        [Test]
        public void IsItAnagram ()
        {
           string firstword = "keret";
           string secondword = "retek";

           bool output = true;

            Assert.AreEqual(output, myOriginal.IsItAnagram(firstword, secondword));
        }
    }
}
