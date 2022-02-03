using MailContainerTest.Data;
using MailContainerTest.Interfaces;
using MailContainerTest.Types;

namespace MailContainerTest.Concretes
{
    public class MailContainerDataStoreFactory : IMailContainerDataStoreFactory
    {
        public IMailContainerDataStore Create(string dataStoreType)
        {
            return Enum.Parse<MailDataStoreType>(dataStoreType) switch
            {
                MailDataStoreType.Backup => new BackupMailContainerDataStore(),
                _ => new MailContainerDataStore()
            };
        }
    }
}
