using AutoMapper;
using ToDo.Domain.DBModel;
using ToDo.Domain.ViewModel;

namespace ToDo.Domain.Mapping
{
    public class OtpMapping : Profile
    {
        public OtpMapping()
        {
            CreateMap<OtpViewModel,Otp>()
                .ReverseMap();
        }
    }
}
