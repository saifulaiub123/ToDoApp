using Microsoft.EntityFrameworkCore;
using ToDo.Domain.DBModel;
using ToDo.Domain.IRepository;
using ToDo.Infrastructure.DBContext;

namespace ToDo.Infrastructure.Repository
{
    public class OtpRepository : Repository<Otp, int>, IOtpRepository
    {
        private readonly ApplicationDbContext _context;
        public OtpRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Otp> GetLatestOtp(string mobileNumber)
        {
            try
            {
                return await _context.Otps.Where(x => x.MobileNumber == mobileNumber)
                    .OrderByDescending(x => x.DateCreated).FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
