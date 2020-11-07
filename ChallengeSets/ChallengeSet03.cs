using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Contains(false))
            {
                return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers != null)
            {
                List<int> oddNumbers = new List<int>() { };
                foreach (int oddNumber in numbers)
                {
                    if (oddNumber % 2 != 0)
                    {
                        oddNumbers.Add(oddNumber);
                    }
                }
                int totalResult = oddNumbers.Sum();
                return totalResult % 2 != 0;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsDigit) && password.Any(char.IsUpper) && password.Any(char.IsLower);
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
            if (divisor != 0)
            {
                return dividend / divisor;
            }
            return 0;
        }

        public int LastMinusFirst(int[] nums)
        {
            return (nums[nums.Length - 1] - nums[0]);
        }
        public int[] GetOddsBelow100()
        {
            List<int> oddsList = Enumerable.Range(0, 100).Where(i => (i % 2 != 0)).ToList();
            int[] latestArray = oddsList.ToArray();
            return latestArray;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }                    
           
        }
    }
}

