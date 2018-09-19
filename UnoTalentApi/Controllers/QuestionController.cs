using UnoTalent.Service.Services.Abstractions;
using UnoTalent.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using UnoTalent.Service.Models;

namespace UnoTalentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ApiController<QuestionVm>
    {
        public QuestionController(IApiService<QuestionVm> apiService) : base(apiService)
        {

        }
    }
}
