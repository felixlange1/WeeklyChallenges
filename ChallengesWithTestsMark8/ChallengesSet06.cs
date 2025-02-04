using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) return false;

            var result = words.Where(w => w != null);
            if (ignoreCase)
            {
                return result.Any(w => w.Contains(word, StringComparison.OrdinalIgnoreCase));
            }
            return result.Any(w => w.Contains(word));
        }
            
    

        public bool IsPrimeNumber(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var grouped = str.GroupBy(c => c);
            var letter = '\0';
            foreach (var group in grouped)
            {
                if (group.Count() == 1) letter = group.Key;
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == letter) return i;
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int streakLength = 0;
            int currentStreak = 1;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentStreak++;
                    if (currentStreak > streakLength) streakLength = currentStreak;
                }

                else
                {
                    currentStreak = 1;
                }
               
            }
            return streakLength;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            
            var newList = new List<double>();
            if (elements == null || elements.Count < n || n < 1) return newList.ToArray();
            for (int i = n - 1; i < elements.Count; i += n)
            {
                newList.Add(elements[i]);
            }
            return newList.ToArray();
        }
    }
}
