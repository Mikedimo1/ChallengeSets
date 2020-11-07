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
            // throw new NotImplementedException();
            List<string> upperCaseList = words.ToList<string>;

            //second attempt looking to remove the old items from the list and append the new manipulated items into the list
            foreach (var item in words)
            {
                string upperCase = item;
                var finalResult = upperCase.ToUpper();
                words.ToArray();
                words.Append(finalResult);

                //}
                ////First attempt bu replacing the list with new values or upper case items
                //for (int i = 0; i < words.Length; i++)
                //{
                //    string upperCaseWord = words[i].ToUpper();
                //    words[i].Replace(words[i], upperCaseWord);
                //}


            }
            words.ToList();
            //return words;
            Console.WriteLine(words);
            Console.WriteLine("TEST");
        
        }
    }
}
