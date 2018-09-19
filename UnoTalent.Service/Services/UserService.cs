using System.Collections.Generic;
using UnoTalent.Service.Services.Abstractions;
using UnoTalent.Data.Entities;
using UnoTalent.Data;
using System.Linq;
using UnoTalent.Service.Mappers;

namespace UnoTalent.Service.Services
{
    public class UserService : ApiService<User, Models.User>
    {
        public UserService(UserMapper mapper, UnoTalentDbContext context) : base(mapper, context)
        {
        }
    }
}
