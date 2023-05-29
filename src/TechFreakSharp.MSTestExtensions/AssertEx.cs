using System;
#pragma warning disable IDE0060 // Remove unused parameter

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechFreakSharp.MSTestExtensions
{
    public static class AssertEx
    {
        public static void IsEmpty(this Assert assert, string? actual)
        {
            IsEmpty(actual);
        }

        public static void IsNotEmpty(this Assert assert, string? actual)
        {
            IsNotEmpty(actual);
        }

        public static void IsEmpty(string? actual)
        {
            if (!string.IsNullOrEmpty(actual))
            {
                throw new AssertFailedException($"Assert.IsEmpty failed. Expected:<{string.Empty}>. Actual:<{actual}>.");
            }
        }

        public static void IsNotEmpty(string? actual)
        {
            if (string.IsNullOrEmpty(actual))
            {
                throw new AssertFailedException($"Assert.IsNotEmpty failed. Expected:<NOT string.Empty>. Actual:<{actual}>.");
            }
        }

        private static string GetMessage(string expected, string actual)
        {
            var expectedFormat = ReplaceInvisibleCharacters(expected);
            var actualFormat = ReplaceInvisibleCharacters(actual);

            // Get the index of the first different character
            var index = expectedFormat.Zip(actualFormat, (c1, c2) => c1 == c2).TakeWhile(b => b).Count();
            var caret = new string(' ', index) + "^";

            return $@"Strings are different.
Expect: <{expectedFormat}>
Actual: <{actualFormat}>
         {caret}";
        }

        private static string ReplaceInvisibleCharacters(string value)
        {
            return value
                .Replace(' ', '·')
                .Replace('\t', '→')
                .Replace("\r", "\\r")
                .Replace("\n", "\\n");
        }
    }
}
