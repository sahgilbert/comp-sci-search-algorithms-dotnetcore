using SimonGilbert.Blog.Algorithms;
using SimonGilbert.Blog.Data;
using Xunit;

namespace SimonGilbert.Blog.Tests
{
    public class BinarySearchTests : DataSetBase
    {
        [Fact]
        public void BinarySearch_Find_First()
        {
            var result = BinarySearch.Find(_dataSetNumbersSmall, 2);

            Assert.Equal(0, result);
        }

        [Fact]
        public void BinarySearch_Find_Middle_One()
        {
            var result = BinarySearch.Find(_dataSetNumbersMedium, 4);

            Assert.Equal(1, result);
        }

        [Fact]
        public void BinarySearch_Find_Middle_Two()
        {
            var result = BinarySearch.Find(_dataSetNumbersMedium, 6);

            Assert.Equal(2, result);
        }

        [Fact]
        public void BinarySearch_Find_Last_One()
        {
            var result = BinarySearch.Find(_dataSetNumbersSmall, 6);

            Assert.Equal(2, result);
        }

        [Fact]
        public void BinarySearch_Find_Last_Two()
        {
            var result = BinarySearch.Find(_dataSetNumbersMedium, 8);

            Assert.Equal(3, result);
        }

        [Fact]
        public void BinarySearch_Find_Null()
        {
            var result = BinarySearch.Find(_dataSetNumbersSmall, 5);

            Assert.Null(result);
        }

        [Fact]
        public void BinarySearch_Find_First_LibraryMethod()
        {
            var result = BinarySearch.FindUsingLibraryMethod(_dataSetNumbersSmall, 2);

            Assert.Equal(0, result);
        }

        [Fact]
        public void BinarySearch_Find_Middle_One_LibraryMethod()
        {
            var result = BinarySearch.FindUsingLibraryMethod(_dataSetNumbersMedium, 4);

            Assert.Equal(1, result);
        }

        [Fact]
        public void BinarySearch_Find_Middle_Two_LibraryMethod()
        {
            var result = BinarySearch.FindUsingLibraryMethod(_dataSetNumbersMedium, 6);

            Assert.Equal(2, result);
        }

        [Fact]
        public void BinarySearch_Find_Last_One_LibraryMethod()
        {
            var result = BinarySearch.FindUsingLibraryMethod(_dataSetNumbersSmall, 6);

            Assert.Equal(2, result);
        }

        [Fact]
        public void BinarySearch_Find_Last_Two_LibraryMethod()
        {
            var result = BinarySearch.FindUsingLibraryMethod(_dataSetNumbersMedium, 8);

            Assert.Equal(3, result);
        }
    }
}