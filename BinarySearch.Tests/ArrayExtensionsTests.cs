using System;
using System.Collections.Generic;
using NUnit.Framework;
using BinarySearch;
using Comporators;

namespace BinarySearch.Tests
{
    [TestFixture]
    public class Tests
    {
        private static IEnumerable<TestCaseData> SearchAlgorithmTestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, 2, new IntegerByAbsComorer()).Returns(2);
                yield return new TestCaseData(new int[] { 0, 1, -2, 2, 4, 5, 6, 7, 8 }, 2, new IntegerByAbsComorer()).Returns(2);
                yield return new TestCaseData(new int[] { 0, 1, 3, 3, 4, 5, 6, 7, 8 }, 2, new IntegerByAbsComorer()).Returns(null);
            }
        }

        [TestCaseSource(nameof(SearchAlgorithmTestCases))]
        public int? SearchAlgorithmTest(int[] source, int item, IComparer<int> comparer)
        {
            return source.Search(item, comparer);
        }

        [Test]
        public void SearchAlgorithmTest_SourceArrayIsNull_ThrowsArgumentNullExeption()
        {
            Assert.Throws<ArgumentNullException>(() => ArrayExtension.Search(null, 0, new IntegerByAbsComorer()));
        }

        [Test]
        public void SearchAlgorithmTest_SearchObjectIsNull_ThrowsArgumentNullExeption()
        {
            var array = new object[] { 0, 1, 3, 5 };
            Assert.Throws<ArgumentNullException>(() => array.Search(null, null));
        }

        [Test]
        public void SearchAlgorithmTest_ComporatorIsNull_ThrowsArgumentNullExeption()
        {
            var array = new int[] { 0, 1, 3, 5 };
            Assert.Throws<ArgumentNullException>(() => array.Search(2, null));
        }
    }
}