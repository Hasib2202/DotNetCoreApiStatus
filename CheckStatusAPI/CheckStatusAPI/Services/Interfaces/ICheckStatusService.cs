using CheckStatusAPI.Models.Responses;
using System.Threading.Tasks;

namespace CheckStatusAPI.Services.Interfaces
{
    public interface ICheckStatusService
    {
        Task<CheckStatusResponse> CheckUserStatusAsync(string msisdn);
    }
}
