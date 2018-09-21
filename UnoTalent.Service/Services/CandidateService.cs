using UnoTalent.Data;
using UnoTalent.Data.Entities;
using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;
using UnoTalent.Service.Services.Abstractions;

namespace UnoTalent.Service.Services
{
    public class CandidateService : ApiService<Candidate, CandidateVm>
    {
        public CandidateService(IMapper<Candidate, CandidateVm> mapper, UnoTalentDbContext context) : base(mapper, context)
        {
            
        }

        public override CandidateVm GetById(int id)
        {
            return base.GetById(id);
        }
    }
}
