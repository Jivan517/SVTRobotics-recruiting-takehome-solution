using SvtRoboticsLoaderApi.Models;

namespace SvtRoboticsLoaderApi.Clients
{
    public class RobotService : IRobotService
    {
        private readonly HttpClient _httpClient;

        public RobotService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public HttpClient Get_httpClient()
        {
            return _httpClient;
        }

        public async Task<IEnumerable<Robot>?> GetAllAsync() =>
            await _httpClient.GetFromJsonAsync<IEnumerable<Robot>>("robots");
    }
}
