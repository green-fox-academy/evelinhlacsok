using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Apples;

namespace ApplesTest
{
    [TextFixture]

    public class ApplesTest
    {
        AppleClass kukac  = new AppleClass();

        [Test]
        public void GetAppleKukac ()
        {
            
            string output = "apple";

            // assert
            Assert.AreEqual(output, kukac.GetApple());
        }
    }
}
