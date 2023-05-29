using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechFreakSharp.MSTestExtensions.Test
{
    [TestClass]
    public class CollectionAssertExTest
    {

        [TestMethod]
        public void IsEmpty_WhenCollectionIsEmpty_DoesNotThrow()
        {
            CollectionAssertEx.IsEmpty(Array.Empty<string>());
        }

        [TestMethod]
        public void IsEmpty_WhenCollectionIsNotEmpty_Throws()
        {
            Assert.ThrowsException<AssertFailedException>(() => CollectionAssertEx.IsEmpty(new[] { "not empty" }));
        }

        [TestMethod]
        public void IsNotEmpty_WhenCollectionIsNotEmpty_DoesNotThrow()
        {
            CollectionAssertEx.IsNotEmpty(new[] { "not empty" });
        }

        [TestMethod]
        public void IsNotEmpty_WhenCollectionIsEmpty_Throws()
        {
            Assert.ThrowsException<AssertFailedException>(() => CollectionAssertEx.IsNotEmpty(Array.Empty<string>()));
        }

        [TestMethod]
        public void IsEmpty_WhenCollectionIsNull_Throws()
        {
            Assert.ThrowsException<AssertFailedException>(() => CollectionAssertEx.IsEmpty((string[])null));
        }

        [TestMethod]
        public void IsNotEmpty_WhenCollectionIsNull_Throws()
        {
            Assert.ThrowsException<AssertFailedException>(() => CollectionAssertEx.IsNotEmpty((string[])null));
        }
    }
}
