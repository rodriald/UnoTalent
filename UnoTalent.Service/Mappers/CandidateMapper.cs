using System;
using System.Collections.Generic;
using System.Text;
using UnoTalent.Data.Entities;
using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;

namespace UnoTalent.Service.Mappers
{
    public class CandidateMapper : IMapper<Candidate, CandidateVm>
    {
        public Candidate Map(CandidateVm model)
        {
            Candidate candidate = new Candidate();
            candidate.Id = model.Id;
            candidate.Name = model.Name;
            return candidate;
        }

        public CandidateVm Map(Candidate entity)
        {
            CandidateVm candidate = new CandidateVm();
            candidate.Id = entity.Id;
            candidate.Name = entity.Name;
            return candidate;
        }

        public List<Candidate> Map(List<CandidateVm> models)
        {
            List<Candidate> candidates = new List<Candidate>();
            foreach (CandidateVm candidate in models)
            {
                candidates.Add(Map(candidate));
            }

            return candidates;
        }

        public List<CandidateVm> Map(List<Candidate> entities)
        {
            List<CandidateVm> candidates = new List<CandidateVm>();
            foreach (Candidate candidate in entities)
            {
                candidates.Add(Map(candidate));
            }

            return candidates;
        }

        public Candidate Map(Candidate entity, CandidateVm model)
        {
            throw new NotImplementedException();
        }
    }
}
