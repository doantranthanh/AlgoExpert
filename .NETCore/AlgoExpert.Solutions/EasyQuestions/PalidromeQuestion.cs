using System.Text;

namespace AlgoExpert.Solutions.EasyQuestions
{
    public class PalidromeQuestion
    {
        // O(n) space | O(n^2) time
        public static bool IsPalidromeSolutionOne(string str)
        {
            var comparedString = string.Empty;
            for (var i = str.Length - 1; i >= 0; i--)
            {
                comparedString += str[i];
            }
            return comparedString == str;
        }

        // O(n) space | O(n) time
        public static bool IsPalidromeSolutionTwo(string str)
        {
            var sb = new StringBuilder();
            for (var i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString() == str;
        }

        // O(n) space | O(n) time
        // Recursion Solution
        public static bool IsPalidromeSolutionRecursion(string str)
        {
            return IsPalidrome(str, 0);
        }

        private static bool IsPalidrome(string str, int i)
        {
            var j = str.Length - i - 1;

            if (i >= j)
            {
                return true;
            }
            return str[i] == str[j] && IsPalidrome(str, i + 1);
        }
    }
}
