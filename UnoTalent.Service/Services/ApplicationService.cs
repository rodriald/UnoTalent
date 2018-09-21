using Microsoft.EntityFrameworkCore;
using UnoTalent.Service.Services.Abstractions;
using UnoTalent.Data.Entities;
using UnoTalent.Data;
using System.Linq;
using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;

namespace UnoTalent.Service.Services
{
    public class ApplicationService : ApiService<Application, ApplicationVm>
    {
        public ApplicationService(IMapper<Application, ApplicationVm> mapper, UnoTalentDbContext context) : base(mapper, context)
        {
        }

        public override ApplicationVm GetById(int id)
        {
            var entity = _context.Applications.Include(x => x.Candidate)
                .Include(x => x.ApplicationQuestions)
                    .ThenInclude(x => x.Question)
                .SingleOrDefault(x => x.Id == id);

            var application = _mapper.Map(entity);

            return application;
        }
    }
}
