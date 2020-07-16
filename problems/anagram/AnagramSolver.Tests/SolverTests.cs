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
            var firstWord = "heart";
            var secondWord = "earth";

            Assert.True(Solver.IsAnagram(firstWord.ToCharArray(), secondWord.ToCharArray()));
        }

        [Fact]
        public void IsAnagram_InvalidAnagramWordsWithDifferentSizes_ReturnFalse()
        {
            var firstWord = "heart";
            var secondWord = "earthth";

            Assert.False(Solver.IsAnagram(firstWord.ToCharArray(), secondWord.ToCharArray()));
        }

        [Fact]
        public void IsAnagram_InvalidAnagramWordsSameSizes_ReturnFalse()
        {
            var firstWord = "python";
            var secondWord = "typton";

            Assert.False(Solver.IsAnagram(firstWord.ToCharArray(), secondWord.ToCharArray()));
        }
    }
}

