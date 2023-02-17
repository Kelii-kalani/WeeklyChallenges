using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";

            foreach (char letter in lowercaseAlphabet)
            {
                if (letter == Char.ToLower(c))
                {
                    return true;
                }
               
            }
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            
            if (numbers == null)
            {
                return 0;
            }
            else if (numbers.Count() == 0)
            {
                return 0;
            }
                return numbers.Min() + numbers.Max();
        }
        public int GetLengthOfShortestString(string str1, string str2)
        {
            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();

            if (ch1.Length < ch2.Length)
            {
                return ch1.Length;
            }
            else
            {
                return ch2.Length;
            }
        }

        public int Sum(int[] numbers)
        {              
            if (numbers == null)
            {
                return 0;
            }
                return numbers.Sum();                                     
        }

        public int SumEvens(int[] numbers)
        {
            int result = 0;
            if (numbers == null)
            {
                return 0;
            }
            foreach (int i in numbers)
            { 
                if (i % 2 == 0)
                {
                    result += i;
                }
            }
            return result;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else if (numbers.Sum()%2 != 0)
            {
                return true;
            }
            else if (numbers.Sum() % 2 == 0)
            {
                return false;
            }
            return true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for (long n = 0; n < number; n++)
            {
                if (n % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
