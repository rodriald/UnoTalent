using Microsoft.AspNetCore.Mvc;
using UnoTalent.Service.Models;
using UnoTalent.Service.Services.Abstractions;

namespace UnoTalentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ApiController<ApplicationVm>
    {
        public ApplicationController(IApiService<ApplicationVm> apiService) : base(apiService)
        {

        }
    }
}
