using System.Collections.Generic;
using UnoTalent.Data.Entities;
using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;

namespace UnoTalent.Service.Mappers
{
    public class ApplicationMapper : IMapper<Application, ApplicationVm>
    {
        public Application Map(ApplicationVm model)
        {
            Application application = new Application();
            application.Id = model.Id;
            application.Name = model.Name;
            return application;
        }

        public ApplicationVm Map(Application entity)
        {
            ApplicationVm application = new ApplicationVm();
            application.Id = entity.Id;
            application.Name = entity.Name;
            application.Questions = new List<QuestionVm>();

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
    }
}
