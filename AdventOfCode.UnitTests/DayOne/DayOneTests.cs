using AdventOfCode.DayOne;
using Xunit;

namespace AdventOfCode.UnitTests.DayOne
{
    public class DayOneTests
    {
        #region FirstSolution

        [Fact]
        public void FirstReturnsThreeForPlusOneMinusTwoPlusThreePlusOne()
        {
            var input = "+1, -2, +3, +1";

            Assert.Equal(3, DayOneSolution.First(input));
        }

        [Fact]
        public void FirstReturnsThreeForPlusOnePlusOnePlusOne()
        {
            var input = "+1, +1, +1";

            Assert.Equal(3, DayOneSolution.First(input));
        }

        [Fact]
        public void FirstReturnsZeroForPlusOnePlusOneMinusTwo()
        {
            var input = "+1, +1, -2";

            Assert.Equal(0, DayOneSolution.First(input));
        }

        [Fact]
        public void FirstReturnsMinusSixForMinusOneMinusTwoMinusThree()
        {
            var input = "-1, -2, -3";

            Assert.Equal(-6, DayOneSolution.First(input));
        }

        #endregion

        #region SecondSolution

        [Fact]
        public void SecondReturnsTwoForPlusOneMinusTwoPlusThreePlusOne()
        {
            var input = "+1, -2, +3, +1";

            Assert.Equal(2, DayOneSolution.Second(input));
        }

        [Fact]
        public void SecondReturnsZeroForPlusOneMinusOne()
        {
            var input = "+1, -1";

            Assert.Equal(0, DayOneSolution.Second(input));
        }

        [Fact]
        public void SecondReturnsTenForPlusThreePlusThreePlusFourMinusTwoMinusFour()
        {
            var input = "+3, +3, +4, -2, -4";

            Assert.Equal(10, DayOneSolution.Second(input));
        }

        [Fact]
        public void SeconReturnsFiveForMinusSixPlusThreePlusEightPlusFiveMinusSix()
        {
            var input = "-6, +3, +8, +5, -6";

            Assert.Equal(5, DayOneSolution.Second(input));
        }

        [Fact]
        public void SecondReturnsFourteenForPlusSevenPlusSevenMinusTwoMinusSevenMinusFour()
        {
            var input = "+7, +7, -2, -7, -4";

            Assert.Equal(14, DayOneSolution.Second(input));
        }

        #endregion
    }
}
