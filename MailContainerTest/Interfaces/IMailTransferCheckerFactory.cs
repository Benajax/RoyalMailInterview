using MailContainerTest.Types;

namespace MailContainerTest.Interfaces
{
    public interface IMailTransferCheckerFactory
    {
        IMailTransferChecker Create(MailType mailType);
    }
}
