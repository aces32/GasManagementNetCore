using System.Net.Http;

namespace MonitorGas.GasManagement.App.Services
{
    public partial class Client : IClient
    {
        public HttpClient HttpClient
        {
            get
            {
                return _httpClient;
            }
        }

    }
}
