using AutoMapper;

namespace AccountManagement.Framework.Data
{
    public class AutoMapperProfileConfiguration: Profile
    {
        public AutoMapperProfileConfiguration(): base()
        {
            //CreateMap<PersonProfile, PersonProfile>().ReverseMap();
        }
    }
}
