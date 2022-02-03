namespace MailContainerTest.Interfaces
{
    public interface IMailContainerDataStoreFactory
    {
        IMailContainerDataStore Create(string dataStoreType);
    }
}
