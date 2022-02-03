using MailContainerTest.Concretes;
using MailContainerTest.Data;
using MailContainerTest.Types;
using NUnit.Framework;

namespace MailContainerTest.Tests
{
    [TestFixture]
    public class MailTransfeCheckerFactoryTests
    {
        private MailTransfeCheckerFactory _mailTransfeCheckerFactory;

       [SetUp]
        public void SetUp()
        {
            _mailTransfeCheckerFactory = new MailTransfeCheckerFactory();
        }

        public void CallingCreate_WIthStandardLetter_ShouldReturnStandardLetterTransferChecker()
        {
            var result = _mailTransfeCheckerFactory.Create(MailType.StandardLetter);
            Assert.IsInstanceOf<StandardLetterTransferChecker>(result);
        }

        public void CallingCreate_WIthLargeLetter_ShouldReturnLargeLetterTransferChecker()
        {
            var result = _mailTransfeCheckerFactory.Create(MailType.LargeLetter);
            Assert.IsInstanceOf<LargeLetterTransferChecker>(result);
        }

        public void CallingCreate_WIthSmallParcel_ShouldReturnSmallParcelTransferChecker()
        {
            var result = _mailTransfeCheckerFactory.Create(MailType.SmallParcel);
            Assert.IsInstanceOf<SmallParcelTransferChecker>(result);
        }

    }
}
