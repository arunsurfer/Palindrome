using Genesys.Palindrome;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Moq;
using System;
using Xunit;

namespace Genesys.Palindrome.Test
{
    public class ProgramTests
    {
        private MockRepository mockRepository;



        public ProgramTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        private Program CreateProgram()
        {
            return new Program();
        }

        [Fact]
        public void Test_Palindrome_Program()
        {
            // Arrange
            var program = this.CreateProgram();

            // Act


            // Assert
            Assert.True(true);
            this.mockRepository.VerifyAll();
        }
    }
}
