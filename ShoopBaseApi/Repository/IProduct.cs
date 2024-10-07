using ShoopBaseApi.Models;

namespace ShoopBaseApi.Repository
{
    public interface IProduct
    {
        Task<IEnumerable<T_Product>> GetAllProductAsync();
        Task<T_Product?> GetProductIdAsync(int ProductId);
        Task AddProductAsynce(T_Product product);
        void DeletProductAsynce(T_Product product);
    }
}
