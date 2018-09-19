using UnoTalent.Service.Services.Abstractions;
using UnoTalent.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using UnoTalent.Service.Models;

namespace UnoTalentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ApiController<UserVm>
    {
        public UserController(IApiService<UserVm> apiService) : base(apiService)
        {
        }
    }
}
