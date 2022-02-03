using MailContainerTest.Concretes;
using MailContainerTest.Types;
using NUnit.Framework;

namespace MailContainerTest.Tests
{
    [TestFixture]
    public class LargeLetterTransferCheckerTests
    {
        private LargeLetterTransferChecker _largeLetterTransferChecker;

       [SetUp]
        public void SetUp()
        {
            _largeLetterTransferChecker = new LargeLetterTransferChecker();
        }

        public void CallingCreate_WithNullContaint_ShouldReturnFalseResult()
        {
            // Arrange
            MailContainer mailContainer = null;
            var request = new MakeMailTransferRequest();

            // Action
            var result = _largeLetterTransferChecker.CheckMailType(mailContainer, request);

            // Assert
            Assert.IsFalse(result.Success);
        }

        // TODO: more test could be added here to test the other branches of the class under test.
    }
}
