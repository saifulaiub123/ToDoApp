using ToDo.Domain.DBModel;

namespace ToDo.Domain.IRepository
{
    public interface IOtpRepository : IRepository<Otp, int>
    {
        Task<Otp> GetLatestOtp(string mobileNumber);
    }
}
