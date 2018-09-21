using System.Collections.Generic;
using System.Linq;
using UnoTalent.Data.Entities;
using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;

namespace UnoTalent.Service.Mappers
{
    public class ApplicationMapper : IMapper<Application, ApplicationVm>
    {
        private readonly IMapper<Candidate, CandidateVm> _candidateMapper;
        private readonly IMapper<Question, QuestionVm> _questionMapper;

        public ApplicationMapper(IMapper<Candidate, CandidateVm> candidateMapper, IMapper<Question, QuestionVm> questionMapper)
        {
            _candidateMapper = candidateMapper;
            _questionMapper = questionMapper;
        }

        public Application Map(ApplicationVm model)
        {
            Application application = new Application();
            application.Id = model.Id;
            application.Name = model.Name;

            if (application.Candidate != null) {
                application.Candidate = _candidateMapper.Map(model.Candidate);
            }
            return application;
        }

        public ApplicationVm Map(Application entity)
        {
            ApplicationVm application = new ApplicationVm();
            application.Id = entity.Id;
            application.Name = entity.Name;
            application.Questions = new List<QuestionVm>();
            if (entity.ApplicationQuestions != null)
            {
                foreach (var question in entity.ApplicationQuestions)
                {
                    application.Questions.Add(_questionMapper.Map(question.Question));
                }
            }

            if (entity.Candidate != null)
            {
                IMapper<Candidate, CandidateVm> mapper = new CandidateMapper();
                application.Candidate = mapper.Map(entity.Candidate);
            }

            return application;
        }

        public List<Application> Map(List<ApplicationVm> models)
        {
            List<Application> applications = new List<Application>();
            foreach (ApplicationVm application in models)
            {
                applications.Add(Map(application));
            }

            return applications;
        }

        public List<ApplicationVm> Map(List<Application> entities)
        {
            List<ApplicationVm> applications = new List<ApplicationVm>();
            foreach (Application application in entities)
            {
                applications.Add(Map(application));
            }

            return applications;
        }

        public Application Map(Application entity, ApplicationVm model) {
            entity.Name = model.Name;

            if (model.Candidate != null) {
                IMapper<Candidate, CandidateVm> mapper = new CandidateMapper();
                entity.Candidate = mapper.Map(model.Candidate);
            }
            return entity;
        }
    }
}
