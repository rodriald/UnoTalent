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
            candidate.Application = model.Application;
            return candidate;
        }

        public CandidateVm Map(Candidate entity)
        {
            CandidateVm candidate = new CandidateVm();
            candidate.Id = entity.Id;
            candidate.Name = entity.Name;
            candidate.Application = entity.Application;
            return candidate;
        }

        public List<Candidate> Map(List<CandidateVm> models)
        {
            List<Candidate> candidates = new List<Candidate>();
            foreach (CandidateVm candidate in models)
            {
                Candidate newCandidate = new Candidate();
                newCandidate.Id = candidate.Id;
                newCandidate.Name = candidate.Name;
                newCandidate.Application = candidate.Application;
                candidates.Add(newCandidate);
            }

            return candidates;
        }

        public List<CandidateVm> Map(List<Candidate> entities)
        {
            List<CandidateVm> candidates = new List<CandidateVm>();
            foreach (Candidate candidate in entities)
            {
                CandidateVm newCandidate = new CandidateVm();
                newCandidate.Id = candidate.Id;
                newCandidate.Name = candidate.Name;
                newCandidate.Application = candidate.Application;
                candidates.Add(newCandidate);
            }

            return candidates;
        }
    }
}
