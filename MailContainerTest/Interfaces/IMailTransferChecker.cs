using MailContainerTest.Types;

namespace MailContainerTest.Interfaces
{
    public interface IMailTransferChecker
    {
        MakeMailTransferResult CheckMailType(MailContainer mailContainer, MakeMailTransferRequest request);
    }
}
