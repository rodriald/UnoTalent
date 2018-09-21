using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UnoTalent.Data;
using UnoTalent.Data.Entities;
using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;
using UnoTalent.Service.Services.Abstractions;

namespace UnoTalent.Service.Services
{
    public class CategoryService : ApiService<Category, CategoryVm>
    {
        public CategoryService(IMapper<Category, CategoryVm> mapper, UnoTalentDbContext context) : base(mapper, context)
        {

        }

        public override CategoryVm GetById(int id)
        {
            var entity = _context.Categories.Include(c => c.Questions).SingleOrDefault(x => x.Id == id);
            return _mapper.Map(entity);
        }

        public override List<CategoryVm> GetAll()
        {
            var entities = _context.Categories.Include(c => c.Questions).ToList();
            return _mapper.Map(entities);
        }
    }
}
