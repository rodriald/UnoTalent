using Microsoft.AspNetCore.Mvc;
using UnoTalent.Service.Models;
using UnoTalent.Service.Services.Abstractions;

namespace UnoTalentApi.Controllers
{
    public class CategoryController : ApiController<CategoryVm>
    {
        public CategoryController(IApiService<CategoryVm> apiService) : base(apiService)
        {

        }
    }
}
