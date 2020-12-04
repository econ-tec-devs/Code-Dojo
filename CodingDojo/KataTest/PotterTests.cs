using System.Collections.Generic;
using Kata;
using NUnit.Framework;

namespace KataTest
{
    public class PotterTests
    {
        private Potter _target;

        [SetUp]
        public void Setup()
        {
            _target = new Potter();
        }

        [Test]
        public void Calculate_EmptyListWithCountOfSameBooks_Return0()
        {
            var countOfSameBooks = new List<int>();
            var expected = 0m;

            ActAndAssert(countOfSameBooks, expected);
        }

        #region SameBooks

        [Test]
        public void Calculate_ListWithOneBook_Return8()
        {
            var countOfSameBooks = new List<int>() { 1 };
            var expected = 8m;

            ActAndAssert(countOfSameBooks, expected);
        }

        [Test]
        public void Calculate_ListWithTwoBook_Return16()
        {
            var countOfSameBooks = new List<int>() { 2 };
            var expected = 16m;

            ActAndAssert(countOfSameBooks, expected);
        }

        [Test]
        public void Calculate_ListWithThreeBook_Return24()
        {
            var countOfSameBooks = new List<int>() { 3 };
            var expected = 24m;

            ActAndAssert(countOfSameBooks, expected);
        }

        [Test]
        public void Calculate_ListWithFourBook_Return32()
        {
            var countOfSameBooks = new List<int>() { 4 };
            var expected = 32m;

            ActAndAssert(countOfSameBooks, expected);
        }

        [Test]
        public void Calculate_ListWithFiveBook_Return40()
        {
            var countOfSameBooks = new List<int>() { 5 };
            var expected = 40m;

            ActAndAssert(countOfSameBooks, expected);
        }

        [Test]
        public void Calculate_ListNoBookAndOneOtherBook_Return8()
        {
            var countOfSameBooks = new List<int>() { 0, 1 };
            var expected = 8m;

            ActAndAssert(countOfSameBooks, expected);
        }

        [Test]
        public void Calculate_ListOneBookAndNoBook_Return8()
        {
            var countOfSameBooks = new List<int>() { 1, 0 };
            var expected = 8m;

            ActAndAssert(countOfSameBooks, expected);
        }

        [Test]
        public void Calculate_LastPosition3Books_Return24()
        {
            var countOfSameBooks = new List<int>() { 0,0,0,0,3 };
            var expected = 24m;

            ActAndAssert(countOfSameBooks, expected);
        }

        #endregion

        #region Different Books

        [Test]
        public void Calculate_TwoDifferntBooks_Return1520Cent()
        {
            var countOfSameBooks = new List<int>() { 1, 1 };
            var expected = 15.2m;

            ActAndAssert(countOfSameBooks, expected);
        }

        [Test]
        public void Calculate_ThreeDifferntBooks_Return2160Cent()
        {
            var countOfSameBooks = new List<int>() { 1, 1, 1 };
            var expected = 21.6m;

            ActAndAssert(countOfSameBooks, expected);
        }
        
        [Test]
        public void Calculate_FourDifferntBooks_Return2560Cent()
        {
            var countOfSameBooks = new List<int>() { 1, 1, 1, 1 };
            var expected = 25.6m;

            ActAndAssert(countOfSameBooks, expected);
        }

        [Test]
        public void Calculate_FiveDifferntBooks_Return3000Cent()
        {
            var countOfSameBooks = new List<int>() { 1, 1, 1, 1, 1 };
            var expected = 30.0m;

            ActAndAssert(countOfSameBooks, expected);
        }

        [Test]
        public void Calculate_TwoDifferntBooksOn4And5_Return1520Cent()
        {
            var countOfSameBooks = new List<int>() { 0, 0, 0, 1, 1 };
            var expected = 15.2m;

            ActAndAssert(countOfSameBooks, expected);
        }

        #endregion

        #region Mixed Test

        [Test]
        public void Calculate_BundleOfTwoBooksDouble_Return1520Cent()
        {
            var countOfSameBooks = new List<int>() { 2, 2 };
            var expected = 2 * 15.2m;

            ActAndAssert(countOfSameBooks, expected);
        }

        [Test]
        public void Calculate_BundleOfThreeBooksDouble_Return1520Cent()
        {
            var countOfSameBooks = new List<int>() { 3, 3 };
            var expected = 3 * 15.2m;

            ActAndAssert(countOfSameBooks, expected);
        }

        [Test]
        public void Calculate_BundleOf2AndOneSingleBook_Return2320Cent()
        {
            var countOfSameBooks = new List<int>() { 2, 1 };
            var expected = 23.2m;

            ActAndAssert(countOfSameBooks, expected);
        }


        #endregion

        private void ActAndAssert(List<int> countOfSameBooks, decimal expected)
        {
            decimal actual = _target.Calculate(countOfSameBooks);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}