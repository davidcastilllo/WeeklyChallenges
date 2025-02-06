using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var count = 0;
            foreach (var i in vals) {
                count++;
            }
            if (count % 2 == 0) {
                return true;
            } else return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else return true;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null) {
                return 0;
            }

            else if (numbers.Count() == 0) {
                return 0;
            }

            else return numbers.Min() + numbers.Max();

            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length <= str2.Length) { return str1.Length; } else { return str2.Length; } 
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null) { return 0; }
            foreach (var i in numbers) {
               sum += i; 
            }

            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers == null) { return 0; }
            foreach (var i in numbers)
            {
                if (i % 2 == 0) { 
                sum += i;
                } 
            }

            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if (numbers == null) { return false; }
            foreach (var i in numbers)
            {
                    sum += i;
            }

            if (sum % 2 == 0) { return false; } else { return true; }
            
        }

        public long CountOfPositiveOddsBelowNumber(int number)
        {
            if (number <= 0)
            {
                return 0;
            }
            
            return (number / 2);
        }
    }
}
