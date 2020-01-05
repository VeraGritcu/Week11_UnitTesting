using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week11_UnitTesting;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class StringTests
    {
        [TestCase("ab-cd", "dc-ba")]
        [TestCase("a-bC-dEf-ghIj", "j-Ih-gfE-dCba")]
        [TestCase("Test1ng-Leet=code-Q!", "Qedo1ct-eeLg=ntse-T!")]

        public void ShouldReturnAValidString(string input, string expected)
        {
            //Arrange

            //Act
            string actual = StringUtils.ReverseString(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]

        public void ShouldThrowAnException()
        {
            //Arrange
            string input = "";


            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => StringUtils.ReverseString(input));

        }


    }
}
