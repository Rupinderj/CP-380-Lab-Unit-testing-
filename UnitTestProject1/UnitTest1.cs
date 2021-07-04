using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Year_2001_Is_not_a_leap_year()

{

 // Arrange

 var p = new Program();

 var expected = false;

 // Act

 var actual = p.IsItALeapYear(2001);

 // Assert

 Assert.AreEqual(expected, actual);

}
    }
}
