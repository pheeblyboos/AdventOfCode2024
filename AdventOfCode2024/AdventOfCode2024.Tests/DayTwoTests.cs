using AdventOfCode2024.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024.Tests
{
    public class DayTwoTests
    {

        [Theory]
        [InlineData("SampleDayTwo-1", 2)]
        public void DayTwoStarOne_Should_Correctly_Calculate(string filepath, int expected)
        {
            // Arrange
            var starOne = new TwoStarOne();

            // Act
            var result = starOne.Run(filepath);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("SampleDayTwo-1", 4)]
        public void DayTwoStarTwo_Should_Correctly_Calculate(string filepath, int expected)
        {
            // Arrange
            var starTwo = new TwoStarTwo();

            // Act
            var result = starTwo.Run(filepath);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
