using ShoopBaseApi.Models;

namespace ShoopBaseApi.Repository
{
    public interface IUser
    {
        Task<IEnumerable<T_User>> GetAllUserAsync();
        Task<T_User?> GetUserIdAsync(int UserId);
        Task AddUserAsynce(T_User user);
        void DeletUserAsynce(T_User user);
    }
}
