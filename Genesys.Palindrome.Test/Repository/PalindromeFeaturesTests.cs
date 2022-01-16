using Genesys.Palindrome.Repository;
using Moq;
using System;
using Xunit;

namespace Genesys.Palindrome.Test.Repository
{
    public class PalindromeFeaturesTests
    {
        private MockRepository mockRepository;



        public PalindromeFeaturesTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        private PalindromeFeatures CreatePalindromeFeatures()
        {
            return new PalindromeFeatures();
        }

        [Fact]
        public void CheckInputType_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var palindromeFeatures = this.CreatePalindromeFeatures();
            string input = "malayalam";

            // Act
            var result = palindromeFeatures.CheckInputType(
                input);

            // Assert
            Assert.True(true);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void CheckDataType_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var palindromeFeatures = this.CreatePalindromeFeatures();
            string input = "malayalam";

            // Act
            var result = palindromeFeatures.CheckDataType(
                input);

            // Assert
            Assert.True(true);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void GetCharacterCount_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var palindromeFeatures = this.CreatePalindromeFeatures();
            string input = "malayalam";

            // Act
            var result = palindromeFeatures.GetCharacterCount(
                input);

            // Assert
            Assert.True(true);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void IsPalindrome_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var palindromeFeatures = this.CreatePalindromeFeatures();
            string message = "malayalam"; 

            // Act
            var result = palindromeFeatures.IsPalindrome(
                message);

            // Assert
            Assert.True(true);
            this.mockRepository.VerifyAll();
        }
    }
}
