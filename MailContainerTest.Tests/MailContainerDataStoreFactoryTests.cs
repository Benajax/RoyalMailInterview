using MailContainerTest.Concretes;
using MailContainerTest.Data;
using MailContainerTest.Types;
using NUnit.Framework;

namespace MailContainerTest.Tests
{
    [TestFixture]
    public class MailContainerDataStoreFactoryTests
    {
        private MailContainerDataStoreFactory _mailContainerDataStoreFactory;

       [SetUp]
        public void SetUp()
        {
            _mailContainerDataStoreFactory = new MailContainerDataStoreFactory();
        }

        public void CallingCreate_WIthBackupDataStore_ShouldReturnBackupMailContainerDataStore()
        {
            var result = _mailContainerDataStoreFactory.Create(MailDataStoreType.Backup.ToString());
            Assert.IsInstanceOf<BackupMailContainerDataStore>(result);
        }

        public void CallingCreate_WithNotBackupDataStore_ShouldRetrunMailContainerDataStore()
        {
            var result = _mailContainerDataStoreFactory.Create(MailDataStoreType.Mail.ToString());
            Assert.IsInstanceOf<MailContainerDataStore>(result);
        }
    }
}
