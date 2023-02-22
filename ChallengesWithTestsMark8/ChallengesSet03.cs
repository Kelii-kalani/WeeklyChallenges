using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool v in vals)
            {
                if (v == false)
                {
                    return true;
                }
            }return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {   
            if (numbers == null)
            {
                return false;
            }

            var odds = new List<int>();

            foreach (int i in numbers) 
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }

            }
            var sumOdds = odds.Sum();

            return (sumOdds % 2 != 0);

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(Char.IsUpper) && password.Any(Char.IsLower) && password.Any(Char.IsDigit)) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return (val[val.Length - 1]);
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var numberList = Enumerable.Range(1, 100).ToList();
            var odds = new List<int>();
            foreach (var i in numberList)
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
            for (int i = 0; i <= words.Length-1; i++)
            {
                words[i] = words[i].ToUpper();

            }
        }
    }
}
