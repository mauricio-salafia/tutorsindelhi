using System;
using System.Collections.Generic;
using System.Linq;

namespace Tutors.Challenge
{
    public class ReverseEachWordProblem
    {
        public static string Solution(string input)
        {
            var result = new List<string>();
            try
            {
                var words = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    var reverse = ReverseWord(word);
                    result.Add(reverse);
                }
            }
            catch (Exception)
            {
                //TODO: Error handling
            }

            return result.Any() ? string.Join(" ", result) : string.Empty;
        }

        private static string ReverseWord(string word)
        {
            var characters = word.ToCharArray().Reverse();
            var result = string.Join("", characters);
            return result;
        }
    }
}
