using System;
using System.Collections.Generic;

namespace AlgoExpert.Solutions.EasyQuestions
{
    public static class TwoSumNumber
    {
        public static List<int> TwoForLoopsSolution(int[] array, int targetSum)
        {
            var result = new List<int>();
            for (int i = 0; i < array.Length - 1; i++)
            {
                var first = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    var second = array[j];
                    if (first + second == targetSum)
                    {
                        if (first > second)
                        {
                            result.Add(second);
                            result.Add(first);
                            return result;
                        }

                        if (first < second)
                        {
                            result.Add(first);
                            result.Add(second);
                            return result;
                        }
                    }
                }
            }

            return result;
        }

        public static List<int> OneForLoopSolution(int[] array, int targetSum)
        {
            var lookUp = new Dictionary<int, bool>();
            foreach (var currentNumber in array)
            {
                var matchingNumber = targetSum - currentNumber;
                if (lookUp.ContainsKey(matchingNumber))
                {
                    var result = new List<int>();
                    if (currentNumber < matchingNumber)
                    {
                        result.Add(currentNumber);
                        result.Add(matchingNumber);
                    }

                    if (currentNumber >= matchingNumber)
                    {
                        result.Add(matchingNumber);
                        result.Add(currentNumber);
                    }
                    return result;
                }
                else
                {
                    lookUp.Add(currentNumber, true);
                }
            }
            return new List<int>();
        }

        public static List<int> TwoPointsSolution(int[] array, int targetSum)
        {
            Array.Sort(array);
            var left = 0;
            var right = array.Length - 1;
            while (left < right)
            {
                var checkSum = array[left] + array[right];
                if (checkSum == targetSum)
                {
                    var result = new List<int>();
                    if (array[left] < array[right])
                    {
                        result.Add(array[left]);
                        result.Add(array[right]);
                        return result;
                    }
                    if (array[left] > array[right])
                    {
                        result.Add(array[right]);
                        result.Add(array[left]);
                        return result;
                    }
                }

                if (checkSum > targetSum)
                {
                    right--;
                }

                if (checkSum < targetSum)
                {
                    left++;
                }
            }
            return new List<int>();
        }
    }
}
