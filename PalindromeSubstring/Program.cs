using System;
using System.Collections.Generic;

namespace PalindromeSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "aba";
            Console.WriteLine(test);
            if (CheckPalindromeReverseString(test))
            {
                Console.WriteLine(test);
            }

        /*
            string testString = RandomString(40);
            List<string> palindromes= new List<string>();

            Console.WriteLine(testString);
            //Console.WriteLine(testString.Substring(2));
            palindromes = ExtractPalindrome(testString);

            foreach (string i in palindromes) { if (i.Length > 1) Console.Write(i + "  "); }
            */
        }
        
        static List<String> ExtractPalindrome(string tString)
        {
            List<string> allPalindromes = new List<string>();
            string tSubstring=null;
            int size = 0;
            int stringLength = tString.Length;

            for (int i = 0; i < stringLength; i++)
            {
                size = 0;
                tSubstring = tString.Substring(i,1);
                //odd palindromes
                while (CheckPalindromeReverseString(tSubstring) && i-size>=0 && i+size< stringLength)
                {
                    allPalindromes.Add(tSubstring);
                    
                    tSubstring = tString.Substring(i,size);
                    size++;
                }
                
                //even palindromes
                if (i < stringLength - 2)
                {
                    if (CheckPalindromeReverseString(tString.Substring(i, i + 1)))
                    {
                        while (CheckPalindromeReverseString(tSubstring) && i - size >= 0 && i + 1 + size < stringLength-1)
                        {
                            allPalindromes.Add(tSubstring);

                            tSubstring = tString.Substring(i - size, i + 1 + size);
                            size++;
                        }
                    }
                }
                
            }
            return allPalindromes;
        }

        static bool CheckPalindromeReverseString(string palindrome)
        {
            char[] reversechar = palindrome.ToCharArray();
            //Array.Reverse(reversechar);
            Console.WriteLine("Array.Reverse(reversechar); String: " + palindrome + "   Reverse String:" + String.Concat(reversechar));
            string reverseString = String.Concat(reversechar);
            Console.Write("string reverseString = String.Concat(reversechar); String: " + palindrome + "   Reverse String:" + reverseString);
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
