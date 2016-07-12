using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgramCreek.Tests
{
    [TestClass]
    public class MergeKSortedArraysTests
    {
        [TestMethod]
        public void MergeKSortedArraysShouldMergeTwoEmptyArrays()
        {
            //GIVEN
            var merger = new MergeKSortedArrays();

            //WHEN
            var mergedArrays = merger.Merge(new[] {new int[] {}, new int[] {}});

            //THEN
            Assert.IsTrue(mergedArrays.SequenceEqual(new int[] {}));
        }

        [TestMethod]
        public void MergeKSortedArraysShouldMergeKEmptyArrays()
        {
            //GIVEN
            var merger = new MergeKSortedArrays();

            //WHEN
            var mergedArrays =
                merger.Merge(new[] {new[] {1, 5, 9, 15}, new[] {2, 6, 33, 66}, new[] {1, 11, 111, 1111, 11111}});

            //THEN
            Assert.IsTrue(mergedArrays.SequenceEqual(new[] {1, 1, 2, 5, 6, 9, 11, 15, 33, 66, 111, 1111, 11111}));
        }
    }
}