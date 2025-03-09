using CheckStatusAPI.Models.Entities;
using System.Threading.Tasks;

namespace CheckStatusAPI.Data.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetUserByMsisdnAsync(string msisdn);
    }
}
