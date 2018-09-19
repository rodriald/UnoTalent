using UnoTalent.Service.Services.Abstractions;
using UnoTalent.Data.Entities;
using UnoTalent.Data;
using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;

namespace UnoTalent.Service.Services
{
    public class ApplicationService : ApiService<Application, ApplicationVm>
    {
        public ApplicationService(IMapper<Application, ApplicationVm> mapper, UnoTalentDbContext context) : base(mapper, context)
        {

        }
    }
}
