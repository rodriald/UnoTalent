using System;
using System.Collections.Generic;
using System.Text;
using UnoTalent.Data.Entities;
using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;

namespace UnoTalent.Service.Mappers
{
    class ApplicationMapper : IMapper<Application, ApplicationVm>
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
            return application;
        }

        public List<Application> Map(List<ApplicationVm> models)
        {
            List<Application> applications = new List<Application>();
            foreach (ApplicationVm application in models)
            {
                Application newApplication = new Application();
                newApplication.Id = application.Id;
                newApplication.Name = application.Name;
                applications.Add(newApplication);
            }

            return applications;
        }

        public List<ApplicationVm> Map(List<Application> entities)
        {
            List<ApplicationVm> applications = new List<ApplicationVm>();
            foreach (Application application in entities)
            {
                ApplicationVm newApplication = new ApplicationVm();
                newApplication.Id = application.Id;
                newApplication.Name = application.Name;
                applications.Add(newApplication);
            }

            return applications;
        }
    }
}
