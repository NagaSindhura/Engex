using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass()]
    public class BinaryPowerofFiveCountTests
    {
        private int expected;

        private int actual;

        private string input;

        private PrivateType service = new PrivateType(typeof(BinaryPowerofFiveCount));

        [TestMethod()]
        public void PowerofFiveCount_returnsExpected_EmptyInput()
        {
            expected = -1;
            input = "";

            var service = new PrivateType(typeof(BinaryPowerofFiveCount));
            actual = Convert.ToInt32(service.InvokeStatic("PowerofFiveCount", input));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PowerofFiveCount_returnsExpected_ValidInput()
        {
            expected = 3;
            actual = 0;
            input = "101101101";

            actual = Convert.ToInt32(service.InvokeStatic("PowerofFiveCount", input));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PowerofFiveCount_InvalidExpected_ShouldNotMatch()
        {
            expected = 3;
            actual = 0;
            input = "1111101";

            actual = Convert.ToInt32(service.InvokeStatic("PowerofFiveCount", input));

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod()]
        public void PowerofFiveCount_returnsExpected_inValidInput()
        {
            expected = -1;
            actual = 0;
            input = "00000";

            actual = Convert.ToInt32(service.InvokeStatic("PowerofFiveCount", input));

            Assert.AreEqual(expected, actual);
        }
    }
}