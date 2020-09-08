using System.Collections.Generic;
using System.Text;

namespace Tutors.Challenge
{
    public class CountCharactersProblem
    {
        public static string Solution(string input)
        {
            var ocurrences = new Dictionary<char, int>();
            var characters = input.ToCharArray();
            int current = 0;
            foreach (var character in characters)
            {
                if (character == ' ')
                {
                    //This line was entered in order to match with the expected value in the unit test.
                    continue;
                }

                if (ocurrences.ContainsKey(character))
                {
                    current = ocurrences[character];
                    ocurrences[character] = ++current;
                }
                else
                {
                    ocurrences.Add(character, 1);
                }
            }

            var result = CreateOutput(ocurrences);
            return result;
        }

        private static string CreateOutput(Dictionary<char, int> ocurrences)
        {
            var sb = new StringBuilder();
            foreach (var ocurrence in ocurrences)
            {
                if (sb.Length > 0)
                {
                    sb.AppendLine();
                }

                sb.AppendFormat("{0} - {1}", ocurrence.Key, ocurrence.Value);
            }

            return sb.ToString();
        }
    }
}
