using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int count = vals.Length;

            return (count % 2) == 0;

        }

        public bool IsNumberEven(int number)
        {
            //number divided by 2 should always equal 0 if it is even
            return number % 2 == 0;
        }


        public bool IsNumberOdd(int num)
        {
            //all odd numbers divided by 2 would equal anything other than 0
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;
            if (length1 > length2)
            {
                return length2;
            }
            else
            {
                return length1;
            }
        }

        public int Sum(int[] numbers)
        {
            int totalSum = 0;
            if (numbers != null)
            {
                foreach (int num in numbers)
                {
                    totalSum = num + totalSum;
                }
            }
            return totalSum;
        }

        public int SumEvens(int[] numbers)
        {
            int sumOfAllNumbers = 0;

            if (numbers != null)
            {
                foreach (int num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        sumOfAllNumbers = num + sumOfAllNumbers;
                    }
                }
            }
            return sumOfAllNumbers;
        }
        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers != null)
            {
                int sumOfAllNumbers = numbers.Sum();
                return sumOfAllNumbers % 2 != 0;
            }
            return false;
        }


        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number > 0)
            {
                if (number % 2 == 0)
                {
                    return number / 2;
                }
                else
                {
                    decimal newNumber = number;
                    long result = (long)(Math.Ceiling((newNumber / 2)) - 1);
                    return result;
                }
            }
            else
            {
                return 0;
            }



        }
    }
}
