using AutoMapper;
using first_asp_app.Data;
using first_asp_app.Models;

namespace first_asp_app.Configurations
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
