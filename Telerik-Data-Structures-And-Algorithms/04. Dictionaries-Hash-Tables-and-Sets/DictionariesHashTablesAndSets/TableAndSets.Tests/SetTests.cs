namespace TableAndSets.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SetImplementation;

    [TestClass]
    public class SetTests
    {
        [TestMethod]
        public void ShouldCreateSetInstanceWithCorrectDefaultValues()
        {
            var set = new Set<int>();
            Assert.AreEqual(0, set.Count);
        }

        [TestMethod]
        public void ShouldCorrectlyAddAllValues()
        {
            var set = new Set<int>();
            set.Add(1);
            set.Add(3);
            set.Add(2);
            set.Add(7);
            set.Add(8);

            Assert.AreEqual(5, set.Count);
        }

        [TestMethod]
        public void ShouldNotAddDuplicateValues()
        {
            var set = new Set<int>();
            set.Add(1);
            set.Add(1);
            set.Add(1);
            set.Add(1);
            set.Add(1);

            Assert.AreEqual(1, set.Count);
        }

        [TestMethod]
        public void ShouldRemoveElementsCorrectly()
        {
            var set = new Set<int>();
            set.Add(5);
            Assert.AreEqual(1, set.Count);
            set.Remove(5);
            Assert.AreEqual(0, set.Count);
        }
    }
}
