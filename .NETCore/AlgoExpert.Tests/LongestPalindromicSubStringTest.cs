using System;
using FluentAssertions;
using Xunit;

namespace AlgoExpert.Tests
{
    public class LongestPalindromicSubStringTest
    {
        [Theory]
        [InlineData("abaxyzzyxf", "xyzzyx")]
        [InlineData("abbbaedf", "abbba")]
        public void ShouldReturnLongestPalindromicSubString(string s, string longestPalindromicSubString)
        {
            var result = LongestPalindromicSubString(s);

            result.Should().Be(longestPalindromicSubString);
        }

        private string LongestPalindromicSubString(string s)
        {
            var currentLongest = new int[] { 0, 1 };
            for (int i = 1; i < s.Length; i++)
            {
                var odd = GetLongestPalindromicStringFrom(s, i - 1, i + 1);
                var even = GetLongestPalindromicStringFrom(s, i - 1, i);
                var longest = GetCurrentLongest(odd, even);
                currentLongest = GetCurrentLongest(longest, currentLongest);
            }
            var leftIdx = currentLongest[0];
            var rightIdx = currentLongest[1];
            return s.Substring(leftIdx, rightIdx - leftIdx);
        }

        private int[] GetCurrentLongest(int[] odd, int[] even)
        {
            var oddLength = odd[1] - odd[0];
            var evenLength = even[1] - even[0];
            if (oddLength > evenLength)
            {
                return odd;
            }
            else
            {
                return even;
            }
        }

        private int[] GetLongestPalindromicStringFrom(string s, int leftIdx, int rightIdx)
        {
            while (leftIdx >= 0 && rightIdx < s.Length)
            {
                if (s[leftIdx] != s[rightIdx])
                {
                    break;
                }
                leftIdx -= 1;
                rightIdx += 1;
            }
            return new int[2] { leftIdx + 1, rightIdx };
        }
    }
}