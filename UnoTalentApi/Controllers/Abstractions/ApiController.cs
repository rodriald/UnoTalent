using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UnoTalent.Data.Entities.Abstractions;
using UnoTalent.Service.Services.Abstractions;

namespace UnoTalentApi.Controllers
{
    public class ApiController<TModel> : ControllerBase where TModel : class
    {
        private readonly IApiService<TModel> _apiService;

        public ApiController(IApiService<TModel> apiService) {
            _apiService = apiService;
        }

        [HttpGet]
        public virtual ActionResult<List<TModel>> Get()
        {
            return _apiService.GetAll();
        }

        [HttpGet("{id}")]
        public virtual ActionResult<TModel> Get(int id)
        {
            var item = _apiService.GetById(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost]
        public virtual IActionResult Post(TModel item)
        {
            int itemId = _apiService.Create(item);
            return Ok();
        }

        [HttpPut("{id}")]
        public virtual IActionResult Put(int id, TModel item)
        {
            _apiService.Update(id, item);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public virtual IActionResult Delete(int id)
        {
            var item = _apiService.Delete(id);
            if (item == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
