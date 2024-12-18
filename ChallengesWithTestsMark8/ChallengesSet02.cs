using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            {
                return (Char.IsLetter(c));
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0);
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any()) return 0;
            else return numbers.Min() + numbers.Max();
            
            // double lowest = numbers.Min();
            // double highest = numbers.Max();
            // return highest + lowest;
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length || str2.Length == str1.Length)
            {
                return str2.Length;
            }
            else if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else if (str1 == "" || str2 == "")
            {
                return 0;
            }
            else 
            {
                return str1.Length;
            }

            
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            else
            {
                int sum = 0;
                foreach (int num in numbers)
                {
                    sum += num;
                }

                return sum;
            }
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            else
            {
                int sumOfEvens = 0;
                foreach (int num in numbers)
                {
                    if (num % 2 ==0)
                    {
                        sumOfEvens += num;
                    }
                    
                }
                return sumOfEvens;
            }
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return false;
            }
            else
            {
                int sum = 0;
                foreach (int num in numbers)
                {
                    sum += num;
                }

                // if (sum % 2 != 0) return true;
                // else return false;

                return sum % 2 != 0;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0) return 0;
            
            {
                int count = 0;
                for (long i = 1; i < number; i += 2)
                {
                    if (i % 2 != 0)
                    {
                        count++;
                    }

                }

                return count;
            }

           
        }
    }
}
