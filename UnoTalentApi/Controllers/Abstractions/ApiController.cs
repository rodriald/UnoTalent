using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UnoTalent.Service.Services.Abstractions;

namespace UnoTalentApi.Controllers
{
    public class ApiController<T> : ControllerBase
    {
        private readonly IApiService<T> _apiService;

        public ApiController(IApiService<T> apiService) {
            _apiService = apiService;
        }

        [HttpGet]
        public virtual ActionResult<List<T>> Get()
        {
            return _apiService.GetAll();
        }

        [HttpGet("{id}")]
        public virtual ActionResult<T> Get(int id)
        {
            var item = _apiService.GetById(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost]
        public virtual IActionResult Post(T item)
        {
            long itemId = _apiService.Create(item);
            return Ok();
        }

        [HttpPut("{id}")]
        public virtual IActionResult Put(int id, T item)
        {
            var oldItem = _apiService.GetById(id);
            if (oldItem == null)
            {
                return NotFound();
            }

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
