using System.Collections.Generic;
using UnoTalent.Data;
using UnoTalent.Data.Entities.Abstractions;
using UnoTalent.Service.Mappers.Abstractions;
using System.Linq;

namespace UnoTalent.Service.Services.Abstractions
{
    public class ApiService<TEntity, TModel> : IApiService<TModel> where TEntity : IEntity where TModel : IEntity
    {
        private IMapper<TEntity, TModel> _mapper;
        private UnoTalentDbContext _context;

        public ApiService(IMapper<TEntity, TModel> mapper, UnoTalentDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public int Create(TModel item)
        {
            TEntity newItem = _mapper.Map(item);
            _context.Set<TEntity>().Add(newItem);
            _context.SaveChanges();
            return newItem.Id;
        }

        public TModel Delete(int id)
        {
            TEntity item = _context.Set<TEntity>().Find(id);
            if (item == null)
            {
                return default(TModel);
            }

            _context.Set<IEntity>().Remove(item);
            _context.SaveChanges();

            return _mapper.Map(item);
        }

        public List<TModel> GetAll()
        {
            return _mapper.Map(_context.Set<TEntity>().ToList());
        }

        public TModel GetById(int id)
        {
            return _mapper.Map(_context.Set<TEntity>().Find(id));
        }

        public TModel Update(int id, TModel item)
        {
            TEntity oldItem = _context.Set<TEntity>().Find(id);

            if (oldItem == null)
            {
                return default(TModel);
            }

            item.Id = oldItem.Id;

            _context.Set<IEntity>().Update(_mapper.Map(item));
            _context.SaveChanges();
            return item;
        }
    }
}
