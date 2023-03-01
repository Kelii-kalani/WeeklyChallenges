using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2 ==0)
                {
                    total += numbers[i];
                }
                else
                {
                    total -= numbers[i];
                }
            }
            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> list = new List<string>();

            list.Add(str1);
            list.Add(str2);
            list.Add(str3);
            list.Add(str4);

            var shoStr = list.OrderBy(x => x.Count()).ToList();
            return shoStr[0].Count();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> list = new List<int>();

            list.Add(number1);
            list.Add(number2);
            list.Add(number3);
            list.Add(number4);

            var smNum = list.OrderBy(x => x).ToList();
            return smNum[0];
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int a = sideLength1;
            int b = sideLength2;
            int c = sideLength3;

            if (a + b > c && b + c > a && c + a > b) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out double number);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var majority = (amount / 2) + 1;

            var count = 0;

            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    count++;
                }
            }
            if (count >= majority)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var ave = numbers.Where(x => x % 2 == 0);
            if (ave.Count() == 0)
                return 0;
            return ave.Average();
        }

        public int Factorial(int number)
        {
            var fact = 1;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = number; i > 0; i--)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
