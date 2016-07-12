using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Sorting.Tests
{
    [TestClass]
    public class SortingTests
    {
        [TestMethod]
        public void SelectionSortShouldSortArrrayOfIntegers()
        {
            //GIVEN
            var expectedOutput = new[] {1, 2, 3, 4, 5};
            var input = new[] {3, 2, 4, 1, 5};
            var algorithm = new SelectionSort();

            //WHEN
            algorithm.Sort(input);

            //THEN
            Assert.IsTrue(expectedOutput.SequenceEqual(input));
        }

        [TestMethod]
        public void SelectionSortShouldStableSortArrrayOfIntegers()
        {
            //GIVEN
            var expectedOutput = new[] {1, 2, 3, 4, 5};
            var input = new[] {3, 2, 4, 1, 5};
            var algorithm = new SelectionSort();

            //WHEN
            algorithm.StableSort(input);

            //THEN
            Assert.IsTrue(expectedOutput.SequenceEqual(input));
        }

        [TestMethod]
        public void InsertionSortShouldSortArrrayOfIntegers()
        {
            //GIVEN
            var expectedOutput = new[] {1, 2, 3, 4, 5};
            var input = new[] {3, 2, 4, 1, 5};
            var algorithm = new InsertionSort();

            //WHEN
            algorithm.Sort(input);

            //THEN
            Assert.IsTrue(expectedOutput.SequenceEqual(input));
        }

        [TestMethod]
        public void QuickSortBasicShouldSortArrrayOfIntegers()
        {
            //GIVEN
            var expectedOutput = new[] {1, 2, 3, 4, 5};
            var input = new[] {3, 2, 4, 1, 5};
            var algorithm = new QuickSortBasic();

            //WHEN
            algorithm.Sort(input);

            //THEN
            Assert.IsTrue(expectedOutput.SequenceEqual(input));
        }

        [TestMethod]
        public void QuickSortSwappingShouldSortArrrayOfIntegers()
        {
            //GIVEN
            var expectedOutput = new[] {1, 2, 3, 4, 5};
            var input = new[] {3, 2, 4, 1, 5};
            var algorithm = new QuickSortSwapping();

            //WHEN
            algorithm.Sort(input);

            //THEN
            Assert.IsTrue(expectedOutput.SequenceEqual(input));
        }

        [TestMethod]
        public void QuickSortOptimizedShouldSortArrrayOfIntegers()
        {
            //GIVEN
            var expectedOutput = new[] {1, 2, 3, 4, 5};
            var input = new[] {3, 2, 4, 1, 5};
            var algorithm = new QuickSortOptimized();

            //WHEN
            algorithm.Sort(input);

            //THEN
            Assert.IsTrue(expectedOutput.SequenceEqual(input));
        }

        [TestMethod]
        public void MergeSortShouldSortArrrayOfIntegers()
        {
            //GIVEN
            var expectedOutput = new[] {1, 2, 3, 4, 5};
            var input = new[] {3, 2, 4, 1, 5};
            var algorithm = new MergeSort();

            //WHEN
            algorithm.Sort(input);

            //THEN
            Assert.IsTrue(expectedOutput.SequenceEqual(input));
        }

        [TestMethod]
        public void MultiKeySortShouldSortArrrayEmployeeEntries()
        {
            //GIVEN
            var e1 = new Employee {GivenName = "A", Surname = "A"};
            var e2 = new Employee {GivenName = "B", Surname = "A"};
            var e3 = new Employee {GivenName = "A", Surname = "B"};
            var e4 = new Employee {GivenName = "A", Surname = "C"};
            var e5 = new Employee {GivenName = "B", Surname = "C"};

            var expectedOutput = new[] {e1, e2, e3, e4, e5};
            var input = new[] {e2, e1, e5, e4, e3};

            var algorithm = new MultiKeySort();

            //WHEN
            algorithm.Sort(input);

            //THEN
            Assert.IsTrue(expectedOutput.SequenceEqual(input));
        }

        [TestMethod]
        public void StableSortShouldSortArrrayEmployeeEntries()
        {
            //GIVEN
            var e1 = new Employee {GivenName = "A", Surname = "A"};
            var e2 = new Employee {GivenName = "B", Surname = "A"};
            var e3 = new Employee {GivenName = "A", Surname = "B"};
            var e4 = new Employee {GivenName = "A", Surname = "C"};
            var e5 = new Employee {GivenName = "B", Surname = "C"};

            var expectedOutput = new[] {e2, e1, e3, e5, e4};
            var input = new[] {e3, e5, e2, e4, e1};

            var algorithm = new StableSort();

            //WHEN
            algorithm.Sort(input);

            //THEN
            Assert.IsTrue(expectedOutput.SequenceEqual(input));
        }
    }
}