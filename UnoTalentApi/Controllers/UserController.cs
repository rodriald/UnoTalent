using UnoTalent.Service.Services.Abstractions;
using UnoTalent.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace UnoTalentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ApiController<UnoTalent.Service.Models.User>
    {
        public UserController(IApiService<UnoTalent.Service.Models.User> apiService) : base(apiService)
        {
        }
    }
}
