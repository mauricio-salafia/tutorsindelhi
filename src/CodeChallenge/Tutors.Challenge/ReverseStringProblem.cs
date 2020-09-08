using System.Linq;

namespace Tutors.Challenge
{
    public class ReverseStringProblem
    {
        public static string Solution(string input)
        {
            var characters = input.ToCharArray().Reverse();
            var result = new string(characters.ToArray());
            return result;
        }
    }
}
