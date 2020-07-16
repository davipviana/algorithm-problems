using System;
using AnagramSolver;
using Xunit;

namespace AnagramSolver.Tests
{
    public class SolverTests
    {
        [Fact]
        public void IsAnagram_ValidAnagram_ReturnTrue()
        {
            var firstWord = "the morse code";
            var secondWord = "here comes dots";

            Assert.True(Solver.IsAnagram(firstWord.ToCharArray(), secondWord.ToCharArray()));
        }

        [Fact]
        public void IsAnagram_InvalidAnagram_ReturnFalse()
        {
            var firstWord = "the morse codes";
            var secondWord = "there comes dots";

            Assert.False(Solver.IsAnagram(firstWord.ToCharArray(), secondWord.ToCharArray()));
        }
    }
}

