

using System.Collections.Generic;

namespace UnoTalent.Service.Mappers.Abstractions
{
    public abstract class IMapper<TEntity, TModel>
    {
        public abstract TEntity Map(TModel model);

        public abstract TModel Map(TEntity entity);

        public abstract List<TEntity> Map(List<TModel> models);

        public abstract List<TModel> Map(List<TEntity> entities);
    }
}
