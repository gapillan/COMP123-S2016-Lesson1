using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class HelloWordUnitTest
    {
        [TestMethod]
        public void HelloWorldToConsoleTestMethod()
        {
            // Arrange 
            string expectedResult = "Hello, World!"; // we have to make it fail first 

            // Act 
            string result = COMP123_S2016_Lesson1.Program.HelloWorldToConsole(); // this is the output result
  
            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
