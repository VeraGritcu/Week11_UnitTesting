using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GoatLatin;

namespace UnitTestGoatLatin
{
    [TestFixture]
    public class Class1
    {
        [TestCase("I speak Goat Latin", "Imaa peaksmaaa oatGmaaaa atinLmaaaaa")]
        [TestCase ("The quick brown fox jumped over the lazy dog", "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa")]
        
        public void ShouldConvertToGoatLatin(string a, string b)
        {
            //Arrange
            string input = a;
            string expected = b;

            //Act

            string actual = GoatLatin.Class1.ConvertToGoatLatin(a);

            //Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
