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
