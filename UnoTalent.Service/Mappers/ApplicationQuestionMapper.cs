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
            ApplicationQuestion applicationQuestion = new ApplicationQuestion();
            applicationQuestion.Id = model.Id;
            applicationQuestion.Application = model.Application;
            applicationQuestion.Question = model.Question;
            return applicationQuestion;
        }

        public ApplicationQuestionVm Map(ApplicationQuestion entity)
        {
            ApplicationQuestionVm applicationQuestion = new ApplicationQuestionVm();
            applicationQuestion.Id = entity.Id;
            applicationQuestion.Application = entity.Application;
            applicationQuestion.Question = entity.Question;
            return applicationQuestion;
        }

        public List<ApplicationQuestion> Map(List<ApplicationQuestionVm> models)
        {
            List<ApplicationQuestion> applicationQuestions = new List<ApplicationQuestion>();
            foreach (ApplicationQuestionVm applicationQuestion in models)
            {
                ApplicationQuestion newApplicationQuestion = new ApplicationQuestion();
                newApplicationQuestion.Id = applicationQuestion.Id;
                newApplicationQuestion.Application = applicationQuestion.Application;
                applicationQuestion.Question = applicationQuestion.Question;
                applicationQuestions.Add(newApplicationQuestion);
            }

            return applicationQuestions;
        }

        public List<ApplicationQuestionVm> Map(List<ApplicationQuestion> entities)
        {
            List<ApplicationQuestionVm> applicationQuestions = new List<ApplicationQuestionVm>();
            foreach (ApplicationQuestion applicationQuestion in entities)
            {
                ApplicationQuestionVm newApplicationQuestion = new ApplicationQuestionVm();
                newApplicationQuestion.Id = applicationQuestion.Id;
                newApplicationQuestion.Application = applicationQuestion.Application;
                applicationQuestion.Question = newApplicationQuestion.Question;
                applicationQuestions.Add(newApplicationQuestion);
            }

            return applicationQuestions;
        }
    }
}
