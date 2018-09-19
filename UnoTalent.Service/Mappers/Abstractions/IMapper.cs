using System.Collections.Generic;

namespace UnoTalent.Service.Mappers.Abstractions
{
    public interface IMapper<TEntity, TModel>
    {
        TEntity Map(TModel model);

        TModel Map(TEntity entity);

        List<TEntity> Map(List<TModel> models);

        List<TModel> Map(List<TEntity> entities);
    }
}
