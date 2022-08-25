using FrondEnd.MangoApp.Models;

namespace MangoApp.Services.IServices
{
    public interface IProductServices
    {
        Task<T> GetAllProductAsync<T>();
        Task<T> GetProductByIdAsync<T>(int Id);
        Task<T> CreateProductAsync<T>(ProductDto productDto);
        Task<T> UpdateProductAsync<T>(ProductDto productDto);
        Task<T> DeleteProductAsync<T>(int Id);
    }
}
