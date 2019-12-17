using System;
using System.Collections.Generic;
using System.Globalization;

namespace AlgoExpert.Solutions.MediumQuestions
{
    public class ThreeNumbersSum
    {
        // Time O(n^3) | Space O(n)
        public static List<int[]> ThreeNumbersSumSolutionOne(int[] arr, int target)
        {
            Array.Sort(arr);
            var tripples = new List<int[]>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int m = j + 1; m < arr.Length; m++)
                    {
                        var sum = arr[i] + arr[j] + arr[m];
                        if (sum == target)
                        {
                            var tripple = new int[3];
                            tripple[0] = arr[i];
                            tripple[1] = arr[j];
                            tripple[2] = arr[m];
                            Array.Sort(tripple);
                            tripples.Add(tripple);
                        }
                    }
                }
            }
            return tripples;
        }

        // O(^2) time | O(n) Space
        public static List<int[]> ThreeNumbersSumSolutionTwo(int[] arr, int targetSum)
        {
            Array.Sort(arr);
            var tripples = new List<int[]>();
            for (int i = 0; i < arr.Length; i++)
            {
                var left = i + 1;
                var right = arr.Length - 1;
                while (left < right)
                {
                    var checkSum = arr[i] + arr[left] + arr[right];

                    if (checkSum == targetSum)
                    {
                        var tripple = new int[3];
                        tripple[0] = arr[i];
                        tripple[1] = arr[left];
                        tripple[2] = arr[right];
                        Array.Sort(tripple);
                        tripples.Add(tripple);
                    }

                    if (checkSum < targetSum)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return tripples;
        }

        public static int TwoPointerSolutionOne(int[] arr, int targetSum)
        {
            var sum = 0;
            var count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
            }
            return count;
        }
    }
}
