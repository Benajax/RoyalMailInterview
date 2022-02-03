using MailContainerTest.Types;

namespace MailContainerTest.Interfaces
{
    public interface IMailContainerDataStore
    {
        MailContainer GetMailContainer(string mailContainerNumber);
        void UpdateMailContainer(MailContainer mailContainer);
    }
}
