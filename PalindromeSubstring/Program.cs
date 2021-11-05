using System;
using System.Collections.Generic;

namespace PalindromeSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            //string testString = "eye bird madam abba";
            string testString = RandomString(10);
            Console.WriteLine(testString);
            //Console.WriteLine((3/2));
            List<string> palindromes= new List<string>();

            palindromes = ExtractPalindrome(testString);
            int count = 0;
            foreach (string i in palindromes) 
            {
                if (i.Length == 1)
                {
                    
                    Console.Write(count + i + "  ");
                    count++;
                }
            }
            
        }
        
        static List<String> ExtractPalindrome(string tString)
        {
            List<string> allPalindromes = new List<string>();
            string tSubstring=null;
            int size = 0;
            int stringLength = tString.Length;

            for (int i = 0; i < stringLength; i++)
            {
                //odd palindromes
                size = 1;
                tSubstring = tString.Substring(i, size);

                while (CheckPalindromeReverseString(tSubstring) && i - (size/2) >= -1 && i + (size/2) < stringLength)
                {
                    Console.WriteLine(i + " substring: " + tSubstring + " size: " + size);
                    allPalindromes.Add(tSubstring);
                    size=size+2;

                    if (i - (size / 2)>=0 && i + (size/2) < stringLength) tSubstring = tString.Substring(i-(size/2), size);

                }

                //even palindromes
                size = 2;
                if(i+size/2<stringLength) tSubstring = tString.Substring(i, size);
                while (CheckPalindromeReverseString(tSubstring) && i - (size / 2) >= -1 && i + (size / 2) < stringLength)
                {
                    Console.WriteLine(i + " substring: " + tSubstring + " size: " + size);
                    allPalindromes.Add(tSubstring);
                    size = size + 2;

                    if (i - (size / 2) >= 0 && i + (size / 2) < stringLength) tSubstring = tString.Substring(i - (size / 2), size);

                }
            }
            return allPalindromes;
        }

        static bool CheckPalindromeReverseString(string palindrome)
        {
            char[] reversechar = palindrome.ToCharArray();
            Array.Reverse(reversechar);
            string reverseString = String.Concat(reversechar);
            if (palindrome == reverseString) return true;
            else return false;

        }

        private static string RandomString(int length = 20)
        {
            string characters = "ABCD";
            Random randomint = new Random();
            char tempChar;
            string randomString="";

            for (int i=0; i < length; i++)
            {
                tempChar = characters[randomint.Next(0, 4)];
                randomString += tempChar;
            }
            return randomString;
        }
    }
}
