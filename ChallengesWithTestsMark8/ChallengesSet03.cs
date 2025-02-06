using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals != null && vals.Length != 0 && vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            if (numbers != null ) { 
            foreach (int n in numbers) {
                if (n % 2 != 0) {
                    sum += n;
                }
            }
        }

            if (sum % 2 != 0) { return true; } else { return false; }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool containerUpper = false;
            bool containerLower = false;
            bool containerNumber = false;

            char[] charArray = password.ToCharArray();

            foreach (char c in charArray) {
                if (Char.IsUpper(c)) {
                    containerUpper = true;
                } 
                
                else if (Char.IsLower(c)) {
                    containerLower = true;
                }
                
                else if (Char.IsDigit(c)) {
                    containerNumber = true;
                }
            }

            if (containerUpper && containerLower && containerNumber == true) { return true; } else { return false; }

        }

        public char GetFirstLetterOfString(string val)
        {
            char[] charArray = val.ToCharArray();
            return charArray[0];

        }

        public char GetLastLetterOfString(string val)
        {
            char[] charArray = val.ToCharArray();
            return charArray[charArray.Length - 1];
        }
        
        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0 || divisor == 0) {
                return 0;
            } else { return dividend / divisor; }
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                throw new ArgumentException("Array must contain at least two elements.");
            }

            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            
            List<int> odds = new List<int>();

            for (int i = 1; i < 100; i += 2)
            {
                odds.Add(i);  
            }
           
            return odds.ToArray();
        }

        public string[] ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper(); 
            }

            return words; 
        }
    }
}
