using Blazored.LocalStorage;
using Blazored.SessionStorage;
using MonitorGas.GasManagement.App.Services.Base;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.App.Services
{
    public class BaseDataService
    {
        protected readonly ILocalStorageService _localStorage;
        protected readonly ISessionStorageService _sessionstorage;
        protected IClient _client;

        public BaseDataService(IClient client, ILocalStorageService localStorage, ISessionStorageService sessionstorage)
        {
            _client = client;
            _localStorage = localStorage;
            _sessionstorage = sessionstorage;
        }

        protected ApiResponse<Guid> ConvertApiExceptions<Guid>(ApiException ex)
        {
            if (ex.StatusCode == 400)
            {
                return new ApiResponse<Guid>() { Message = "Validation errors have occured.", ValidationErrors = ex.Response, Success = false };
            }
            else if (ex.StatusCode == 404)
            {
                return new ApiResponse<Guid>() { Message = "The requested item could not be found.", Success = false };
            }
            else
            {
                return new ApiResponse<Guid>() { Message = "Something went wrong, please try again.", Success = false };
            }
        }

        protected async Task AddBearerToken()
        {
            if (await _sessionstorage.ContainKeyAsync("oidc.user:https://dev-p-zm5f3q.us.auth0.com:bC2ksJF635cJks5hgCeRiyn0MHZAxNIu"))
            {
                var authOKey = await _sessionstorage.GetItemAsync<Aut0TokenModel>("oidc.user:https://dev-p-zm5f3q.us.auth0.com:bC2ksJF635cJks5hgCeRiyn0MHZAxNIu");
                _client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authOKey.access_token);
            }               

        }
    }
}
