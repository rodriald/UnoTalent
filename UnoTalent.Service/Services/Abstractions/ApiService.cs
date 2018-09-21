using System.Collections.Generic;
using UnoTalent.Data;
using UnoTalent.Data.Entities.Abstractions;
using UnoTalent.Service.Mappers.Abstractions;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace UnoTalent.Service.Services.Abstractions
{
    public class ApiService<TEntity, TModel> : IApiService<TModel>
        where TEntity : class, IEntity
        where TModel : class
    {
        protected IMapper<TEntity, TModel> _mapper;
        protected UnoTalentDbContext _context;

        public ApiService(IMapper<TEntity, TModel> mapper, UnoTalentDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public virtual int Create(TModel item)
        {
            var newItem = _mapper.Map(item);
            _context.Set<TEntity>().Add(newItem);
            _context.SaveChanges();

            return (int) newItem.Id;
        }

        public virtual TModel Delete(int id)
        {
            TEntity item = _context.Set<TEntity>().Find(id);
            if (item == null)
            {
                return null;
            }

            _context.Set<TEntity>().Remove(item);
            _context.SaveChanges();

            return _mapper.Map(item);
        }

        public virtual List<TModel> GetAll()
        {
            var entities =_context.Set<TEntity>().AsNoTracking().ToList();
            return _mapper.Map(entities);
        }

        public virtual TModel GetById(int id)
        {
            return _mapper.Map(_context.Set<TEntity>().Find(id));
        }

        public virtual TModel Update(int id, TModel item)
        {
            var entity = _mapper.Map(item);
            entity.Id = id;
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
            return _mapper.Map(entity);
        }
    }
}
