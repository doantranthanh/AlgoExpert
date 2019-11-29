using AlgoExpert.Solutions.EasyQuestions;
using FluentAssertions;
using Xunit;

namespace AlgoExpert.Tests.EasyQuestions
{
    public class PalidromeQuestionTests
    {
        [Theory]
        [InlineData("a")]
        [InlineData("abba")]
        [InlineData("abcba")]
        public void ShouldReturnTrueForPalidromeStringWithSolutionOne(string str)
        {
            var result = PalidromeQuestion.IsPalidromeSolutionOne(str);

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("ab")]
        [InlineData("abbac")]
        [InlineData("abcbad")]
        public void ShouldReturnFalseForNotPalidromeStringWithSolutionOne(string str)
        {
            var result = PalidromeQuestion.IsPalidromeSolutionOne(str);

            result.Should().BeFalse();
        }

        [Theory]
        [InlineData("a")]
        [InlineData("abba")]
        [InlineData("abcba")]
        public void ShouldReturnTrueForPalidromeStringWithSolutionTwo(string str)
        {
            var result = PalidromeQuestion.IsPalidromeSolutionOne(str);

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("ab")]
        [InlineData("abbac")]
        [InlineData("abcbad")]
        public void ShouldReturnFalseForNotPalidromeStringWithSolutionTwo(string str)
        {
            var result = PalidromeQuestion.IsPalidromeSolutionOne(str);

            result.Should().BeFalse();
        }


        [Theory]
        [InlineData("a")]
        [InlineData("abba")]
        [InlineData("abcba")]
        public void ShouldReturnTrueForPalidromeStringWithRecursionSolution(string str)
        {
            var result = PalidromeQuestion.IsPalidromeSolutionRecursion(str);

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("ab")]
        [InlineData("abbac")]
        [InlineData("abcbad")]
        public void ShouldReturnFalseForNotPalidromeStringWithRecursionSolution(string str)
        {
            var result = PalidromeQuestion.IsPalidromeSolutionRecursion(str);

            result.Should().BeFalse();
        }
    }
}
