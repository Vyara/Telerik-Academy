namespace SortingHomework.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Utils;

    [TestClass]
    public class MergeSorterTests
    {
        private static MergeSorter<int> sorter;

        [ClassInitialize]
        public static void Initilize(TestContext context)
        {
            sorter = new MergeSorter<int>();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldThrowIfACollectionIsNull()
        {
            sorter.Sort(null);
        }

        [TestMethod]
        public void ShouldSortARandomCollectionProperly()
        {
            IList<int> collection =
                RandomCollectionGenerator.GetRandomIntegers(1000);

            sorter.Sort(collection);

            Assert.IsTrue(IsSorted(collection));
        }

        [TestMethod]
        public void ShouldSortAnAlreadySortedCollectionProperly()
        {
            IList<int> collection =
                RandomCollectionGenerator.GetSortedIntegers(1000);

            sorter.Sort(collection);

            Assert.IsTrue(IsSorted(collection));
        }

        [TestMethod]
        public void ShouldSortAReverseSortedCollectionProperly()
        {
            IList<int> collection =
                RandomCollectionGenerator.GetReversedIntegers(1000);

            sorter.Sort(collection);

            Assert.IsTrue(IsSorted(collection));
        }

        private static bool IsSorted(IList<int> collection)
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                if (collection[i] > collection[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}