using ShoppingCenter.Web.Models;

namespace ShoppingCenter.Web.Services
{
    public interface IProductService
    {
        Task<ApiResponse> GetProductsAsync(string point);
    }
}
