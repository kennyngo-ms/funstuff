using System;
using System.Collections.Generic;

namespace PalindromeSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "eye bird madam abba";
            //string testString = RandomString(40);
            int minSize = 1;
            Console.WriteLine(testString);
            List<string> palindromes= new List<string>();
            HashSet<string> uniquePalindromes = new HashSet<string>();

            palindromes = ExtractPalindrome(testString);

            Console.Write("\nPalindromes: ");
            foreach (string i in palindromes) 
            {   
                //print all palindrome with lenght greater than minSize
                if (i.Length > minSize) Console.Write(i + "  ");
                uniquePalindromes.Add(i);
            }

            Console.Write("\nUnique Palindromes: ");
            foreach (string i in uniquePalindromes)
            {
                //print all palindrome with lenght greater than minSize
                if (i.Length > minSize) Console.Write(i + "  ");
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

                while (CheckPalindrome(tSubstring) && i - (size/2) >= -1 && i + (size/2) < stringLength)
                {
                    allPalindromes.Add(tSubstring);
                    size=size+2;

                    if (i - (size / 2)>=0 && i + (size/2) < stringLength) tSubstring = tString.Substring(i-(size/2), size);

                }

                //even palindromes
                size = 2;
                if(i+size/2<stringLength) tSubstring = tString.Substring(i, size);
                while (CheckPalindrome(tSubstring) && i - (size / 2) >= -1 && i + (size / 2) < stringLength)
                {
                    allPalindromes.Add(tSubstring);
                    size = size + 2;

                    if (i - (size / 2)+1 >= 0 && i + (size / 2) < stringLength) tSubstring = tString.Substring(i - (size / 2)+1, size);
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

        static bool CheckPalindrome(string palindrome)
        {
            if (palindrome == null) return false;
            else if (palindrome[0] == palindrome[palindrome.Length - 1]) return true;
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
