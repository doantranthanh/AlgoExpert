using System;
using AlgoExpert.Solutions.MediumQuestions;
using FluentAssertions;
using Xunit;

namespace AlgoExpert.Tests.MediumQuestions
{
    public class ThreeNumbersSumTest
    {
        [Fact]
        public void ShouldReturnExpectedThreeNumbersSumToTargetNumber()
        {
            var arr = new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };
            var targetNumber = 0;

            var result = ThreeNumbersSum.ThreeNumbersSumSolutionOne(arr, targetNumber);

            result.Count.Should().Be(3);
        }

        [Fact]
        public void ShouldReturnEmpty2DArraySumToTargetNumber()
        {
            var arr = new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };
            var targetNumber = 45;

            var result = ThreeNumbersSum.ThreeNumbersSumSolutionOne(arr, targetNumber);

            result.Count.Should().Be(0);
        }

        [Fact]
        public void ShouldReturnExpectedThreeNumbersSumToTargetNumberSolutionTwo()
        {
            var arr = new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };
            var targetNumber = 0;

            var result = ThreeNumbersSum.ThreeNumbersSumSolutionTwo(arr, targetNumber);

            result.Count.Should().Be(3);
            result[0][0].Should().Be(-8);
            result[0][1].Should().Be(2);
            result[0][2].Should().Be(6);
        }

        [Fact]
        public void ShouldReturnEmpty2DArraySumToTargetNumberSolutionTwo()
        {
            var arr = new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };
            var targetNumber = 45;

            var result = ThreeNumbersSum.ThreeNumbersSumSolutionTwo(arr, targetNumber);

            result.Count.Should().Be(0);
        }


        [Fact]
        public void ShouldReturnEmpty2DArraySumToTargetTwoPoints()
        {
            var arr = new int[] { 1, 2, 5, 4, 2 };
            var targetNumber = 8;

            var result = ThreeNumbersSum.TwoPointerSolutionOne(arr, targetNumber);

            result.Should().Be(0);
        }
    }
}
