using AlgoExpert.Solutions.EasyQuestions;
using FluentAssertions;
using Xunit;

namespace AlgoExpert.Tests.EasyQuestions
{
    public class TwoNumberSumTest
    {
        [Fact]
        public void Return_Expected_The_Two_Number_With_Order_With_Two_For_Loops_Solution()
        {
            var array = new[] { 3, 5, -4, 8, 11, 1, -1, 6 };
            const int targetSum = 10;

            var result = TwoSumNumber.TwoForLoopsSolution(array, targetSum);

            result[0].Should().Be(-1);
            result[1].Should().Be(11);
        }

        [Fact]
        public void Return_Empty_Array_With_Two_For_Loops()
        {
            var array = new[] { 3, 5, -4, 8, 11, 1, -1, 6 };
            const int targetSum = 20;

            var result = TwoSumNumber.TwoForLoopsSolution(array, targetSum);

            result.Count.Should().Be(0);
        }

        [Fact]
        public void Return_Expected_The_Two_Number_With_Order_With_One_For_Loop_Solution()
        {
            var array = new[] { 3, 5, -4, 8, 11, 1, -1, 6 };
            const int targetSum = 10;

            var result = TwoSumNumber.OneForLoopSolution(array, targetSum);

            result[0].Should().Be(-1);
            result[1].Should().Be(11);
        }

        [Fact]
        public void Return_Empty_Array_With_One_For_Loop()
        {
            var array = new[] { 3, 5, -4, 8, 11, 1, -1, 6 };
            const int targetSum = 20;

            var result = TwoSumNumber.OneForLoopSolution(array, targetSum);

            result.Count.Should().Be(0);
        }

        [Fact]
        public void Return_Expected_The_Two_Number_With_Order_With_Two_Pointers_Solution()
        {
            var array = new[] { 3, 5, -4, 8, 11, 1, -1, 6 };
            const int targetSum = 13;

            var result = TwoSumNumber.TwoPointsSolution(array, targetSum);

            result[0].Should().Be(5);
            result[1].Should().Be(8);
        }

        [Fact]
        public void Return_Expected_The_Empty_Array_With_Two_Pointers_Solution()
        {
            var array = new[] { 3, 5, -4, 8, 11, 1, -1, 6 };
            const int targetSum = 33;

            var result = TwoSumNumber.TwoPointsSolution(array, targetSum);

            result.Count.Should().Be(0);
        }

        [Fact]
        public void Return_The_Expected_Great_Most_Divider()
        {
            var result = GreatDivider(12, 16);

            result.Should().Be(4);
        }

        private static int GreatDivider(int m, int n)
        {
            var r = m % n;
            while (r != 0)
            {
                m = n;
                n = r;
                r = m % n;
            }

            return n;
        }
    }
}
