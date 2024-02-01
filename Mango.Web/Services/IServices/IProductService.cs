using Mango.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface IProductService : IBaseService
    {
        Task<T> GetAllProductsAsync<T>(string Token);
        Task<T> GetProductByIdAsync<T>(int id, string Token);
        Task<T> CreateProductAsync<T>(ProductDto productDto, string Token);
        Task<T> UpdateProductAsync<T>(ProductDto productDto, string Token);
        Task<T> DeleteProductAsync<T>(int id, string Token);
    }
}
