using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using UnoTalent.Data.Entities;
using UnoTalent.Service.Services.Abstractions;
using UnoTalent.Data.Entities;

namespace UnoTalentApi.Controllers
{
    public class UserController : ApiController<User>
    {
        public UserController(IApiService<User> apiService) : base(apiService)
        {
        }
    }
}
