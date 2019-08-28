using LeetCodeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeLibraryTests
{
    [TestClass]
    public class TwoSumTests
    {
        private TwoSum _Sut;

        [TestInitialize]
        public void Init()
        {
            this._Sut = new TwoSum();
        }

        [TestMethod]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 }, true)]
        [DataRow(new int[] { 2, 5, 5, 11 }, 10, new int[] { 1, 2 }, true)]
        [DataRow(new int[] { 3, 2, 3 }, 6, new int[] { 0, 2 }, true)]
        [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 }, true)]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 0 }, false)]
        public void GivenAnArrayAndTarget_WhenRun1_ThenReturnsIndicies(int[] nums, int target, int[] expectedResult, bool valid)
        {
            var result = this._Sut.Run1(nums, target);
            if (valid)
                CollectionAssert.AreEqual(result, expectedResult);
            else
                CollectionAssert.AreNotEqual(result, expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 }, true)]
        [DataRow(new int[] { 2, 5, 5, 11 }, 10, new int[] { 1, 2 }, true)]
        [DataRow(new int[] { 3, 2, 3 }, 6, new int[] { 0, 2 }, true)]
        [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 }, true)]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 0 }, false)]
        public void GivenAnArrayAndTarget_WhenRun2_ThenReturnsIndicies(int[] nums, int target, int[] expectedResult, bool valid)
        {
            var result = this._Sut.Run2(nums, target);
            if (valid)
                CollectionAssert.AreEqual(result, expectedResult);
            else
                CollectionAssert.AreNotEqual(result, expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 }, true)]
        [DataRow(new int[] { 2, 5, 5, 11 }, 10, new int[] { 1, 2 }, true)]
        [DataRow(new int[] { 3, 2, 3 }, 6, new int[] { 0, 2 }, true)]
        [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 }, true)]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 0 }, false)]
        public void GivenAnArrayAndTarget_WhenRun3_ThenReturnsIndicies(int[] nums, int target, int[] expectedResult, bool valid)
        {
            var result = this._Sut.Run3(nums, target);
            if (valid)
                CollectionAssert.AreEqual(result, expectedResult);
            else
                CollectionAssert.AreNotEqual(result, expectedResult);
        }

        [TestMethod]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 }, true)]
        [DataRow(new int[] { 2, 5, 5, 11 }, 10, new int[] { 1, 2 }, true)]
        [DataRow(new int[] { 3, 2, 3 }, 6, new int[] { 0, 2 }, true)]
        [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 }, true)]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 0 }, false)]
        public void GivenAnArrayAndTarget_WhenRun4_ThenReturnsIndicies(int[] nums, int target, int[] expectedResult, bool valid)
        {
            var result = this._Sut.Run4(nums, target);
            if (valid)
                CollectionAssert.AreEqual(result, expectedResult);
            else
                CollectionAssert.AreNotEqual(result, expectedResult);
        }
    }
}