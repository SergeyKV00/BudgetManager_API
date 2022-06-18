using AutoMapper;
using BudgetManager.Models;
using BudgetManager.ViewModels;

namespace BudgetManager.Profiles
{
    public class UserMapperConfiguration : Profile
    {
        public UserMapperConfiguration()
        {
            CreateMap<CreateUserViewModel, User>();
            CreateMap<UpdateUserViewModel, User>();
        }
    }
}
