using System;
using System.Collections.Generic;
using System.Text;

namespace Tutors.Challenge
{
    public class ReverseOrderWordsProblem
    {
        public static string Solution(string input)
        {
            var words = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var sb = new StringBuilder();
            for(int index = words.Length -1; index >= 0; index--)
            {
                sb.Append(words[index]);
                if(index > 0)
                {
                    sb.Append(" ");
                }
            }

            return sb.ToString();
        }
    }
}
