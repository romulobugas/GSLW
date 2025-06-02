using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using GSLW.Core.Models.Dtos;

namespace GSLW.Desktop.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5000/") };
        }

        public async Task<bool> LoginAsync(LoginDto dto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/login", dto);
            return response.IsSuccessStatusCode;
        }
    }
}
