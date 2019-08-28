using LeetCodeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeLibraryTests
{
    [TestClass]
    public class ReverseIntegerTests
    {
        private ReverseInteger _Sut;

        [TestInitialize]
        public void Init()
        {
            this._Sut = new ReverseInteger();
        }

        [TestMethod]
        [DataRow(1234, 4321, true)]
        [DataRow(-123, -321, true)]
        [DataRow(-32768, -86723, true)]
        public void GivenAnInteger_WhenRun1_ThenReverses(int input, int expectedResult, bool valid)
        {
            var result = this._Sut.Run1(input);
            if (valid)
                Assert.AreEqual(expectedResult, result);
            else
                Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(1234, 4321, true)]
        [DataRow(-123, -321, true)]
        [DataRow(-32768, -86723, true)]
        public void GivenAnInteger_WhenRun2_ThenReverses(int input, int expectedResult, bool valid)
        {
            var result = this._Sut.Run2(input);
            if (valid)
                Assert.AreEqual(expectedResult, result);
            else
                Assert.AreNotEqual(expectedResult, result);
        }
    }
}