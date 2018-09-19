using UnoTalent.Service.Services.Abstractions;
using UnoTalent.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using UnoTalent.Service.Models;

namespace UnoTalentApi.Controllers
{
    public class QuestionController : ApiController<QuestionVm>
    {
        public QuestionController(IApiService<QuestionVm> apiService) : base(apiService)
        {

        }
    }
}
