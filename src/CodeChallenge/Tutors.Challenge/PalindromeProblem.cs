using System;
using System.Collections.Generic;
using System.Text;

namespace Tutors.Challenge
{
    public class PalindromeProblem
    {
        public static string Solution(string input)
        {
            bool result = false;
            try
            {
                var sequence = input.ToCharArray();
                result = IsPalindrome(0, sequence.Length, sequence);
            }
            catch (Exception)
            {
                //TODO: Error handling
            }

            return result ? "Palindrome" : "Not Palindrome";
        }

        private static bool IsPalindrome(int index, int length, char[] sequence)
        {
            var left = sequence[index];
            var right = sequence[length - 1 - index];
            var half = Convert.ToInt32(length / 2);
            bool result = true;
            if(left == right && index < half)
            {
                result = IsPalindrome(++index, length, sequence);
            }
            else if (left != right)
            {
                result = false;
            }

            return result;
        }
    }
}
