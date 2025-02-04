using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int remainder = startNumber % n;
            return startNumber - remainder + n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return false;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1]) return false;
            }
            
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int result = 0;
            if (numbers == null || numbers.Length == 0) return result;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0) result += numbers[i + 1];
            }
            return result;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            var result = "";
            if (words == null || words.Length == 0) return result;
            result = string.Join(" ", words.Select(word => word.Trim()).Where(word => !string.IsNullOrWhiteSpace(word)));
            if (result == "") return result;
            if (result.EndsWith(".")) return result;
            return result + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var newElements = new List<double>();
            if (elements == null) return newElements.ToArray();
            for (int i = 3; i < elements.Count; i += 4)
            {
                newElements.Add(elements[i]);
            }
            return newElements.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            bool result = false;
            for (int i = 0; i < nums.Length - 1; i++)
            {
        
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber) result = true;
                }
  
            }
            return result;
        }
    }
}
