using AutoMapper;
using LeaveManagementApplication.Data;
using LeaveManagementApplication.Models;

namespace LeaveManagementApplication.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeViewModel>().ReverseMap();
        }
    }
}
