using SimonGilbert.Blog.Algorithms;
using SimonGilbert.Blog.Data;
using Xunit;

namespace SimonGilbert.Blog.Tests
{
    public class JumpSearchTests : DataSetBase
    {
        [Fact]
        public void JumpSearch_Find_First()
        {
            var result = JumpSearch.Find(_dataSetNumbersSmall, 2);

            Assert.Equal(0, result);
        }

        [Fact]
        public void JumpSearch_Find_Middle_One()
        {
            var result = JumpSearch.Find(_dataSetNumbersSmall, 4);

            Assert.Equal(1, result);
        }

        [Fact]
        public void JumpSearch_Find_Middle_Two()
        {
            var result = JumpSearch.Find(_dataSetNumbersMedium, 6);

            Assert.Equal(2, result);
        }

        [Fact]
        public void JumpSearch_Find_Last_One()
        {
            var result = JumpSearch.Find(_dataSetNumbersSmall, 6);

            Assert.Equal(2, result);
        }

        [Fact]
        public void JumpSearch_Find_Last_Two()
        {
            var result = JumpSearch.Find(_dataSetNumbersMedium, 8);

            Assert.Equal(3, result);
        }

        [Fact]
        public void JumpSearch_Find_Null()
        {
            var result = JumpSearch.Find(_dataSetNumbersSmall, 5);

            Assert.Null(result);
        }
    }
}