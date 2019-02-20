using SimonGilbert.Blog.Algorithms;
using SimonGilbert.Blog.Data;
using Xunit;

namespace SimonGilbert.Blog.Tests
{
    public class LinearSearchTests : DataSetBase
    {
        [Fact]
        public void LinearSearch_Find_First()
        {
            var result = LinearSearch.Find(_dataSetNumbersSmall, 2);

            Assert.Equal(0, result);
        }

        [Fact]
        public void LinearSearch_Find_Middle()
        {
            var result = LinearSearch.Find(_dataSetNumbersSmall, 4);

            Assert.Equal(1, result);
        }

        [Fact]
        public void LinearSearch_Find_Last()
        {
            var result = LinearSearch.Find(_dataSetNumbersSmall, 6);

            Assert.Equal(2, result);
        }

        [Fact]
        public void LinearSearch_Find_Null()
        {
            var result = LinearSearch.Find(_dataSetNumbersSmall, 5);

            Assert.Null(result);
        }

        [Fact]
        public void LinearSearch_Find_First_Lambda()
        {
            var result = LinearSearch.FindUsingLambda(_dataSetNumbersSmall, 2);

            Assert.Equal(0, result);
        }

        [Fact]
        public void LinearSearch_Find_Middle_Lambda()
        {
            var result = LinearSearch.FindUsingLambda(_dataSetNumbersSmall, 4);

            Assert.Equal(1, result);
        }

        [Fact]
        public void LinearSearch_Find_Last_Lambda()
        {
            var result = LinearSearch.FindUsingLambda(_dataSetNumbersSmall, 6);

            Assert.Equal(2, result);
        }

        [Fact]
        public void LinearSearch_Find_Null_Lambda()
        {
            var result = LinearSearch.FindUsingLambda(_dataSetNumbersSmall, 5);

            Assert.Null(result);
        }
    }
}