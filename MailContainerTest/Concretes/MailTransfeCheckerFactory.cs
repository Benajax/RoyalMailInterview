using MailContainerTest.Interfaces;
using MailContainerTest.Types;

namespace MailContainerTest.Concretes
{
    public class MailTransfeCheckerFactory : IMailTransferCheckerFactory
    {
        public IMailTransferChecker Create(MailType mailType)
        {
            switch (mailType)
            {
                case MailType.StandardLetter:
                    return new StandardLetterTransferChecker();
                case MailType.LargeLetter:
                    return new LargeLetterTransferChecker();
                case MailType.SmallParcel:
                    return new SmallParcelTransferChecker();
                default:
                    throw new NotSupportedException($"The mail type '{mailType}' is not supported");
            }
        }
    }
}
