using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Contains(false))
            {
                return true;
            }
            else return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else
            {
                int sum = 0;
                // for (int i = 0; i < numbers.Count(); i++)
                // {
                //     sum += numbers.ElementAt(i);
                //
                // }
                foreach (var num in numbers)
                {
                    sum += num;
                }

                if (sum % 2 == 0)
                {
                    return false;
                }
                else return true;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isUpper = false;
            bool isLower = false;
            bool isDigit = false;

            foreach (char c in password)
            {
                if (Char.IsUpper(c))
                {
                    isUpper = true;
                }
                if (Char.IsLower(c))
                {
                    isLower = true;
                }
                if (Char.IsDigit(c))
                {
                    isDigit = true;
                }
                if (isUpper && isLower && isDigit)
                {
                    return true;
                }
            }
            return false;

        }
    


public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var odds = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            string newWordUpper;
            for (int i = 0; i < words.Length; i++)
            {
                newWordUpper = words[i].ToUpper();
                words[i] = newWordUpper;
            }
        }
    }
}
