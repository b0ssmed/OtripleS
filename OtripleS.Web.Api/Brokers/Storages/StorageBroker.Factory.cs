using Microsoft.Extensions.Configuration;

namespace OtripleS.Web.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public static StorageBroker CreateBroker(IConfiguration configuration)
        {
            return new StorageBroker(configuration);
        }
    }
}
