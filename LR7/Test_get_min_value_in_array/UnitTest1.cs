using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LR7;

namespace Test_get_min_value_in_array
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] simpleArray = { 2,1,3};
            int actualValue = Program.getMinValueIndex(simpleArray);
            int expectedValue = 1;
            Assert.AreEqual(actualValue,expectedValue);
        }
    }
}
