using Microsoft.AspNetCore.Mvc;
using UnoTalent.Service.Models;
using UnoTalent.Service.Services.Abstractions;

namespace UnoTalentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ApiController<CandidateVm>
    {
        public CandidateController(IApiService<CandidateVm> apiService) : base(apiService)
        {

        }
    }
}
