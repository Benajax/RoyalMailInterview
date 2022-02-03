using MailContainerTest.Interfaces;
using MailContainerTest.Settings;
using MailContainerTest.Types;
using Microsoft.Extensions.Options;

namespace MailContainerTest.Services
{
    public class MailTransferService : IMailTransferService
    {
        private readonly IMailContainerDataStoreFactory _mailContainerDataStoreFactory;
        private readonly IMailTransferCheckerFactory _mailTransferCheckerFactory;
        private readonly IOptions<AppSettings> _appSettings;
        public MailTransferService(
            IMailContainerDataStoreFactory mailContainerDataStoreFactory,
            IMailTransferCheckerFactory mailTransferCheckerFactory,
            IOptions<AppSettings> appSettings)
        {
            _mailContainerDataStoreFactory = mailContainerDataStoreFactory;
            _mailTransferCheckerFactory = mailTransferCheckerFactory;
            _appSettings = appSettings;
        }
        public MakeMailTransferResult MakeMailTransfer(MakeMailTransferRequest request)
        {
            var mailContainerDataStore = _mailContainerDataStoreFactory.Create(_appSettings.Value.DataStoreType);
            var mailContainer = mailContainerDataStore.GetMailContainer(request.SourceMailContainerNumber);
            var result = _mailTransferCheckerFactory.Create(request.MailType).CheckMailType(mailContainer, request);

            if (result.Success)
            {
                mailContainer.Capacity -= request.NumberOfMailItems;
                mailContainerDataStore.UpdateMailContainer(mailContainer);
            }

            return result;
        }
    }
}
