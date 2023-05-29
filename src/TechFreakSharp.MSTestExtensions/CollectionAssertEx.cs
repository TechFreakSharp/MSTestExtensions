#pragma warning disable IDE0060 // Remove unused parameter

using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechFreakSharp.MSTestExtensions
{
    public static class CollectionAssertEx
    {
        public static void IsEmpty(this CollectionAssert assert, ICollection collection)
        {
            IsEmpty(collection);
        }

        public static void IsNotEmpty(this CollectionAssert assert, ICollection collection)
        {
            IsNotEmpty(collection);
        }

        public static void IsEmpty(ICollection collection)
        {
            if (collection.Count != 0)
            {
                throw new AssertFailedException($"Assert.IsEmpty failed. Expected:<0>. Actual:<{collection.Count}>.");
            }
        }

        public static void IsNotEmpty(ICollection collection)
        {
            if (collection.Count == 0)
            {
                throw new AssertFailedException($"Assert.IsNotEmpty failed. Expected:<NOT 0>. Actual:<{collection.Count}>.");
            }
        }
    }
}
