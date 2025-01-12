using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            // int sum = 0;
            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     
            //     if (i % 2 == 0)
            //     {
            //         sum += i;
            //     }
            //     else
            //     {
            //         sum -= i;
            //     }
            // }
            // return sum;
            
            return numbers.Sum(number => number % 2 == 0 ? number : -number);
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<string>() { str1, str2, str3, str4 };
            return list.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>() { number1, number2, number3, number4 };
            return list.Min(x => x);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 &&
                    sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            double number;
            return double.TryParse(input, out number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return (objs.Count(o => o == null) > objs.Length / 2);
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
    
            var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
            if (!evenNumbers.Any()) return 0;
    
            return evenNumbers.Average();            
            // if (numbers == null || numbers.Length == 0 || numbers.All(x => x % 2 != 0)) return 0;
            // return numbers.Where(x => x % 2 == 0).Average();
         }

        public int Factorial(int number)
        {
            // if (number <= 1) return 1;
            // var list = new List<int>();
            // for (int i = 1; i <= number; i++)
            // {
            //     list.Add(i);
            // }
            //
            // USING LINQ:
            //
            // var result = list.Aggregate((total, current) => total * current);
            // return result;
            //
            // OR COULD DO WITH A FOREACH LOOP:
            //
            // var result = 1;
            // foreach (var num in list)
            // {
            //     result *= num;
            // }
            
            // return result;

            if (number < 0) throw new ArgumentOutOfRangeException();
            
            int result = 1;
            for (int i = number; i > 0; i--)
            {
                result *= i;
                
            };
            return result;


        }
    }
}
