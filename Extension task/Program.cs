using Extension_task.Extension;

namespace Extension_task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TASK 1

            string sentence = "Bugun hava cox cox yaxsidir ";
            sentence.WordCount("cox");

            //TASK 2

            int num = 3553;
            Console.WriteLine(num.IsPalindrome());


            //TASK 3

            string word = "Salam123";
            Console.WriteLine(word.HasAnyDigit());


        }
    }
}