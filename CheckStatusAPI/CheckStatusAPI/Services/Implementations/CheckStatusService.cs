using CheckStatusAPI.Data.Interfaces;
using CheckStatusAPI.Models.Responses;
using CheckStatusAPI.Services.Interfaces;
using System.Threading.Tasks;

namespace CheckStatusAPI.Services.Implementations
{
    public class CheckStatusService : ICheckStatusService
    {
        private readonly IUserRepository _userRepository;

        public CheckStatusService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<CheckStatusResponse> CheckUserStatusAsync(string msisdn)
        {
            var user = await _userRepository.GetUserByMsisdnAsync(msisdn);

            // If user is null, return status = "0"
            if (user == null)
            {
                return new CheckStatusResponse
                {
                    Status = "0",
                    Message = "Active user is not found"
                };
            }

            // If user exists, check IsActive
            if (user.IsActive)
            {
                return new CheckStatusResponse
                {
                    Status = "1",
                    Message = "User is already subscribed"
                };
            }
            else
            {
                return new CheckStatusResponse
                {
                    Status = "0",
                    Message = "Active user is not found"
                };
            }
        }
    }
}
