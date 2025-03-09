using CheckStatusAPI.Data.Interfaces;
using CheckStatusAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CheckStatusAPI.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetUserByMsisdnAsync(string msisdn)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Msisdn == msisdn);
        }
    }
}
