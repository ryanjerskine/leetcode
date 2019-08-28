using LeetCodeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeLibraryTests
{
    [TestClass]
    public class PalindromeNumberTests
    {
        private PalindromeNumber _Sut;

        [TestInitialize]
        public void Init()
        {
            this._Sut = new PalindromeNumber();
        }

        [TestMethod]
        [DataRow(0, true)]
        [DataRow(121, true)]
        [DataRow(1221, true)]
        [DataRow(-1221, false)]
        public void GivenNumber_WhenRun1_ThenReturnsPalindrome(int number, bool isPalindrome)
        {
            var result = this._Sut.Run1(number);
            if (isPalindrome)
                Assert.IsTrue(result);
            else
                Assert.IsFalse(result);
        }
    }
}