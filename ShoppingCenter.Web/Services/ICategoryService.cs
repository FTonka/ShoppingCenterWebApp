using ShoppingCenter.Web.Models;

namespace ShoppingCenter.Web.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetProductCategoriesAsync();
    }
}
