using Microsoft.AspNetCore.Mvc;
using UnoTalent.Service.Models;
using UnoTalent.Service.Services.Abstractions;

namespace UnoTalentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ApiController<CategoryVm>
    {
        public CategoryController(IApiService<CategoryVm> apiService) : base(apiService)
        {

        }
    }
}
