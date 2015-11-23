namespace SortingHomework.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void ShouldReturnFalseWhenSearchingForANonExistingItemInCollection()
        {
            int[] items = new int[]
            {
                12, 126, 125, -1512, 16, 9823, -235, -32592,
                2358239, -9235, -9876253, 237568, 829356289,
                56253, 11, 5252, 3435, 9012797, 12486124, 667
            };
            SortableCollection<int> collection = new SortableCollection<int>(items);

            bool isFound = collection.BinarySearch(13);

            Assert.IsFalse(isFound);
        }

        [TestMethod]
        public void ShouldReturnTrueWhenSearchingForANonExistingItemInCollection_NumberIsAtRandomPosition()
        {
            int[] items = new int[]
            {
                12, 126, 125, -1512, 16, 9823, -235, -32592,
                2358239, -9235, -9876253, 237568, 829356289,
                56253, 11, 5252, 3435, 9012797, 12486124, 667
            };
            SortableCollection<int> collection = new SortableCollection<int>(items);

            bool isFound = collection.BinarySearch(5252);

            Assert.IsTrue(isFound);
        }

        [TestMethod]
        public void ShouldReturnTrueWhenSearchingForANonExistingItemInCollection_NumberIsAtTheFirstPosition()
        {
            int[] items = new int[]
            {
                12, 126, 125, -1512, 16, 9823, -235, -32592,
                2358239, -9235, -9876253, 237568, 829356289,
                56253, 11, 5252, 3435, 9012797, 12486124, 667
            };
            SortableCollection<int> collection = new SortableCollection<int>(items);

            bool isFound = collection.BinarySearch(12);

            Assert.IsTrue(isFound);
        }

        [TestMethod]
        public void ShouldReturnTrueWhenSearchingForANonExistingItemInCollection_WhenNumberIsAtTheFirstPosition_NumberIsAtTheLastPosition()
        {
            int[] items = new int[]
            {
                 12, 126, 125, -1512, 16, 9823, -235, -32592,
                2358239, -9235, -9876253, 237568, 829356289,
                56253, 11, 5252, 3435, 9012797, 12486124, 667
            };
            SortableCollection<int> collection = new SortableCollection<int>(items);

            bool isFound = collection.BinarySearch(667);

            Assert.IsTrue(isFound);
        }
    }
}
