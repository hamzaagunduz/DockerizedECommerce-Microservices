using MultiShop.DtoLayer.OrderDtos;

namespace MultiShop.WebUI.Services.OrderServices
{
    public interface IOrderOderingService
    {
        Task<List<ResultOrderingByUserIdDto>> GetOrderingByUserId(string id);
    }
}
