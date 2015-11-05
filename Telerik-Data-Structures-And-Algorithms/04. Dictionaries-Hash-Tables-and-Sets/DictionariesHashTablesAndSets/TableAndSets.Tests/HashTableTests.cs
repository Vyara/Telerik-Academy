namespace TableAndSets.Tests
{
    using HashTableImplementation;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void ShouldCreateHashTableInstanceWithRightDefaultParameters()
        {
            var table = new CustomHashTable<int, int>();
            Assert.AreEqual(0, table.Count);
        }

        [TestMethod]
        public void ShouldAddCorrectNumberOfElements()
        {
            var table = new CustomHashTable<int, int>();
            table.Add(1, 3);
            table.Add(2, 5);
            table.Add(3, 7);
            Assert.AreEqual(3, table.Count);
        }

        [TestMethod]
        public void ShouldReturnCorrectValueByKey()
        {
            var table = new CustomHashTable<int, int>();
            table.Add(1, 200);
            var result = 0;
            var found = table.Find(1, out result);

            Assert.AreEqual(200, result);
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void ShouldReturnDefaultValueWhenKey()
        {
            var table = new CustomHashTable<int, int>();
            table.Add(1, 200);
            var result = 555;
            var found = table.Find(8, out result);

            Assert.AreEqual(default(int), result);
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void ShouldAutoResizeInnerCollection()
        {
            var table = new CustomHashTable<int, int>(1);
            table.Add(1, 113);
            table.Add(2, 411);
            table.Add(3, 231);

            Assert.AreEqual(3, table.Count);
        }

        [TestMethod]
        public void ShouldReturnDefaultValueAfterElementIsRemoved()
        {
            var table = new CustomHashTable<int, int>();
            table.Add(7, 7);
            int result;

            Assert.IsTrue(table.Find(7, out result));
            table.Remove(7);
            Assert.IsFalse(table.Find(7, out result));
            Assert.AreEqual(default(int), result);
        }
    }
}
