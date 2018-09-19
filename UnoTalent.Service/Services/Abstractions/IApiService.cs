using System.Collections.Generic;

namespace UnoTalent.Service.Services.Abstractions
{
    public interface IApiService<TModel>
    {
        List<TModel> GetAll();

        TModel GetById(int id);
        int Create(TModel item);
        TModel Delete(int id);
        TModel Update(int id, TModel item);
    }
}
