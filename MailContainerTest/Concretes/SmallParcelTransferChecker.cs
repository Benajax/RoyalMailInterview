using MailContainerTest.Interfaces;
using MailContainerTest.Types;

namespace MailContainerTest.Concretes
{
    public class SmallParcelTransferChecker : IMailTransferChecker
    {
        public MakeMailTransferResult CheckMailType(MailContainer mailContainer, MakeMailTransferRequest request)
        {
            var result = new MakeMailTransferResult() { Success = true };

            if (mailContainer == null)
            {
                result.Success = false;
            }
            else if (!mailContainer.AllowedMailType.HasFlag(AllowedMailType.SmallParcel))
            {
                result.Success = false;

            }
            else if (mailContainer.Status != MailContainerStatus.Operational)
            {
                result.Success = false;
            }

            return result;
        }
    }
}
