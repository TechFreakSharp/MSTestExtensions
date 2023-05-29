using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechFreakSharp.MSTestExtensions.Test
{
    [TestClass]
    public class AssertExTest
    {
        [TestMethod]
        public void IsEmpty_WhenStringIsEmpty_DoesNotThrow()
        {
            AssertEx.IsEmpty(string.Empty);
        }

        [TestMethod]
        public void IsEmpty_WhenStringIsNotEmpty_Throws()
        {
            Assert.ThrowsException<AssertFailedException>(() => AssertEx.IsEmpty("not empty"));
        }

        [TestMethod]
        public void IsNotEmpty_WhenStringIsNotEmpty_DoesNotThrow()
        {
            AssertEx.IsNotEmpty("not empty");
        }

        [TestMethod]
        public void IsNotEmpty_WhenStringIsEmpty_Throws()
        {
            Assert.ThrowsException<AssertFailedException>(() => AssertEx.IsNotEmpty(string.Empty));
        }

        [TestMethod]
        public void IsEmpty_WhenStringIsNull_Throws()
        {
            Assert.ThrowsException<AssertFailedException>(() => AssertEx.IsEmpty((string)null));
        }

        [TestMethod]
        public void IsNotEmpty_WhenStringIsNull_Throws()
        {
            Assert.ThrowsException<AssertFailedException>(() => AssertEx.IsNotEmpty((string)null));
        }
    }
}