using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_task.Extension
{
    public static class Extension
    {
        public static void WordCount(this string sentence , string word) 
        {
            //TASK 1

            string[] newArr = sentence.Split(' ');
            int count = 0;
            for (int i = 0; i < newArr.Length; i++)
            {
                if (newArr[i] == word)
                {
                    count ++;
                }
            }
            Console.WriteLine($"Daxil olunan soz bu cumlede {count} defe tekrarlanmisdir !!! ");
        }


        //TASK 2

        public static bool IsPalindrome(this int num)
        {
            int num1 = num;
            int reverseNum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reverseNum = reverseNum * 10 + digit;
                num /= 10;
            }

            if(num1 ==reverseNum) return true;
            else return false;
        }


        //TASK 3


        public static bool HasAnyDigit(this string word)
        {
            for (int i = 0;i < word.Length;i++)
            {
                if (char.IsDigit(word[i])) return true;    
            }
            return false;
        }






    }
}
