using System;
using System.Collections.Generic;
using System.Text;
using UnoTalent.Data.Entities;
using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;

namespace UnoTalent.Service.Mappers
{
    class ApplicationQuestionMapper : IMapper<ApplicationQuestion, ApplicationQuestionVm>
    {
        public ApplicationQuestion Map(ApplicationQuestionVm model)
        {
            ApplicationQuestion question = new ApplicationQuestion();

            IMapper<Question, QuestionVm> mapper = new QuestionMapper();
            question.Question = mapper.Map(model.Question);

            IMapper<Application, ApplicationVm> apmapper = new ApplicationMapper();
            question.Application = apmapper.Map(model.Application);

            return question;
        }

        public ApplicationQuestionVm Map(ApplicationQuestion entity)
        {
            ApplicationQuestionVm question = new ApplicationQuestionVm();
            question.Id = entity.Id;

            IMapper<Question, QuestionVm> mapper = new QuestionMapper();
            question.Question = mapper.Map(entity.Question);

            IMapper<Application, ApplicationVm> apmapper = new ApplicationMapper();
            question.Application = apmapper.Map(entity.Application);
            return question;
        }

        public List<ApplicationQuestion> Map(List<ApplicationQuestionVm> models)
        {
            List<ApplicationQuestion> questions = new List<ApplicationQuestion>();
            foreach (var applicationQuestion in models)
            {
                questions.Add(Map(applicationQuestion));
            }

            return questions;
        }

        public List<ApplicationQuestionVm> Map(List<ApplicationQuestion> entities)
        {
            List<ApplicationQuestionVm> questions = new List<ApplicationQuestionVm>();
            foreach (var applicationQuestion in entities)
            {
                questions.Add(Map(applicationQuestion));
            }

            return questions;
        }
    }
}
