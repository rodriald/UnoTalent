using UnoTalent.Service.Services.Abstractions;
using UnoTalent.Data.Entities;
using UnoTalent.Data;
using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;

namespace UnoTalent.Service.Services
{
    public class UserService : ApiService<User, UserVm>
    {
        public UserService(IMapper<User, UserVm> mapper, UnoTalentDbContext context) : base(mapper, context)
        {
        }
    }
}
