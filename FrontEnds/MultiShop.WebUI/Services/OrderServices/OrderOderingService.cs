using MultiShop.DtoLayer.OrderDtos;
using Newtonsoft.Json;

namespace MultiShop.WebUI.Services.OrderServices
{
    public class OrderOderingService : IOrderOderingService
    {
        private readonly HttpClient _httpClient;
        public OrderOderingService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ResultOrderingByUserIdDto>> GetOrderingByUserId(string id)
        {
            //http://localhost:7128/api/Orderings/GetOrderingByUserId/1
            //http://localhost:5000/services/Order/Orderings/GetOrderingByUserId/6c376236-55a9-4a26-9ca8-8d129949a93c
            var responseMessage = await _httpClient.GetAsync($"Orderings/GetOrderingByUserId/{id}");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultOrderingByUserIdDto>>(jsonData);
            return values;
        }
    }
}
