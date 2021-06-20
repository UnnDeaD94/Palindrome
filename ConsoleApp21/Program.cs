using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            string _inputstr = string.Empty;
            Console.Write("Enter a string : ");
            _inputstr = Console.ReadLine();

            Console.WriteLine(isPalindrome(_inputstr).ToString());
            Console.ReadLine();
        }
        public static Boolean isPalindrome(String text)
        {
            string _reversestr = string.Empty;
            bool result = false;
            if (text != null)
            {
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    _reversestr += text[i].ToString();
                }
                if (_reversestr == text)
                {
                    Console.WriteLine("String is Palindrome Input = {0} and Output= {1}", text, _reversestr);
                    result = true;
                }
                else
                {
                    Console.WriteLine("String is not Palindrome Input = {0} and Output= {1}", text, _reversestr);
                }
            }
            return result;
        }
    }
}