using System;
using System.Collections.Generic;
using System.Text;
using UnoTalent.Data;
using UnoTalent.Data.Entities;
using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;
using UnoTalent.Service.Services.Abstractions;

namespace UnoTalent.Service.Services
{
    class CandidateService : ApiService<Candidate, CandidateVm>
    {
        public CandidateService(IMapper<Candidate, CandidateVm> mapper, UnoTalentDbContext context) : base(mapper, context)
        {

        }
    }
}
