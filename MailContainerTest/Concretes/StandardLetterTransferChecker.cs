using MailContainerTest.Interfaces;
using MailContainerTest.Types;

namespace MailContainerTest.Concretes
{
    public class StandardLetterTransferChecker : IMailTransferChecker
    {
        public MakeMailTransferResult CheckMailType(MailContainer mailContainer, MakeMailTransferRequest request)
        {
            var result = new MakeMailTransferResult() { Success = true };

            if (mailContainer == null)
            {
                result.Success = false;
            }
            else if (!mailContainer.AllowedMailType.HasFlag(AllowedMailType.StandardLetter))
            {
                result.Success = false;
            }

            return result;
        }
    }
}
