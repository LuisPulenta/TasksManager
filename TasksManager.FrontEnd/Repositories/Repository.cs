using System.Text.Json;
using TasksManager.FrontEnd.Repository;
using TasksManager.Shared.Models;

namespace TasksManager.FrontEnd.Repositories
{
    public class Repository : IRepository
    {
        private readonly HttpClient _httpClient;

        public Repository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Response<T>> GetAsync<T>(string url)
        {
            var responseHttp = await _httpClient.GetAsync(url);
            if (!responseHttp.IsSuccessStatusCode)
            {
                return new Response<T>
                {
                    IsSuccess = false,
                    Message = "Fail to get results"
                };
            }
            
            var responseString = await responseHttp.Content.ReadAsStringAsync();
            var responseJson=JsonSerializer.Deserialize<T>(responseString);

            return new Response<T>
            {
                IsSuccess = true,
                Result=responseJson
            };
        }
    }
}
