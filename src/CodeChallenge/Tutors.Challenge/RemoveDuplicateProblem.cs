using System.Collections.Generic;

namespace Tutors.Challenge
{
    public class RemoveDuplicateProblem
    {
        public static string Solution(string input)
        {
            var uniques = new List<char>();
            var characters = input.ToCharArray();
            foreach (var character in characters)
            {
                if (uniques.Contains(character))
                {
                    continue;
                }

                uniques.Add(character);
            }

            var result = new string(uniques.ToArray());
            return result;
        }
    }
}
