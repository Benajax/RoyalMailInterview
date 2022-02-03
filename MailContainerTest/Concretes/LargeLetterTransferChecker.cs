using MailContainerTest.Interfaces;
using MailContainerTest.Types;

namespace MailContainerTest.Concretes
{
    public class LargeLetterTransferChecker : IMailTransferChecker
    {
        public MakeMailTransferResult CheckMailType(MailContainer mailContainer, MakeMailTransferRequest request)
        {
            var result = new MakeMailTransferResult() { Success = true};

            if (mailContainer == null)
            {
                result.Success = false;
            }
            else if (!mailContainer.AllowedMailType.HasFlag(AllowedMailType.LargeLetter))
            {
                result.Success = false;
            }
            else if (mailContainer.Capacity < request.NumberOfMailItems)
            {
                result.Success = false;
            }

            return result;
        }
    }
}
