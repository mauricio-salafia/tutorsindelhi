using Xunit;

namespace Tutors.Challenge.UnitTest
{
    public class SolveProblemUnitTest
    {
        [Theory]
        [InlineData("hello world", "dlrow olleh")]
        public void SolveReverseString_Success(string input, string expected)
        {
            //Act
            var actual = ReverseStringProblem.Solution(input);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("madam", "Palindrome")]
        [InlineData("step on no pets", "Palindrome")]
        [InlineData("book", "Not Palindrome")]
        public void SolvePalindrome_Success(string input, string expected)
        {
            //Act
            var actual = PalindromeProblem.Solution(input);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Welcome to Csharp corner", "corner Csharp to Welcome")]
        public void SolveReverseOrderWords_Succes(string input, string expected)
        {
            //Act
            var actual = ReverseOrderWordsProblem.Solution(input);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Welcome to Csharp corner", "emocleW ot prahsC renroc")]
        public void SolveReverseEachWord_Success(string input, string expected)
        {
            //Act
            var actual = ReverseEachWordProblem.Solution(input);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello world", "h - 1\r\ne - 1\r\nl - 3\r\no - 2\r\nw - 1\r\nr - 1\r\nd - 1")]
        public void SolveCountCharacters_Success(string input, string expected)
        {
            //Act
            var actual = CountCharactersProblem.Solution(input);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("csharpcorner", "csharpone")]
        public void SolveRemoveDuplicate_Success(string input, string expected)
        {
            //Act
            var actual = RemoveDuplicateProblem.Solution(input);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
