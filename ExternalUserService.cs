// ExternalServices/ExternalUserService.cs
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using MiPrimeraApi.Models.ExternalUsers;

namespace MiPrimeraApi.ExternalServices
{
    public class ExternalUserService
    {
        private readonly HttpClient _httpClient;

        public ExternalUserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new System.Uri("https://reqres.in/api/");
        }

        public async Task<ExternalUsersResponse?> GetUsersAsync() // Hecho nullable
        {
            var response = await _httpClient.GetAsync("users");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<ExternalUsersResponse>(content);
            }
            else
            {
                throw new HttpRequestException($"Error al consumir la API externa: {response.StatusCode}");
            }
        }
    }
}