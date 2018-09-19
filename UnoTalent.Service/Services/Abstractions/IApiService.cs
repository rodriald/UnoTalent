using System.Collections.Generic;

namespace UnoTalent.Service.Services.Abstractions
{
    public interface IApiService<TModel>
    {
        List<TModel> GetAll();

        TModel GetById(long id);
        int Create(TModel item);
        TModel Delete(long id);
        TModel Update(long id, TModel item);
    }
}
