using AdventOfCode2024.Challenges;

namespace AdventOfCode2024.Tests
{
    public class DayOneTests
    {
        [Theory]
        [InlineData("SampleDayOne-1", 11)]
        [InlineData("SampleDayOne-2", 7)]
        [InlineData("SampleDayOne-3", 6)]
        [InlineData("SampleDayOne-4", 9)]
        public void DayOneStarOne_Should_Correctly_Calculate(string filepath, int expected)
        {
            var starOne = new OneStarOne();
            var result = starOne.Run(filepath);

            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData("SampleDayOne-1", 31)]
        [InlineData("SampleDayOne-2", 74)]
        [InlineData("SampleDayOne-3", 49)]
        [InlineData("SampleDayOne-4", 23)]
        public void DayOneStarTwo_Should_Correctly_Calculate(string filepath, int expected)
        {
            var starTwo = new OneStarTwo();
            var result = starTwo.Run(filepath);

            Assert.Equal(expected, result);

        }
    }
}