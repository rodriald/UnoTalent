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
        private readonly IMapper<Application, ApplicationVm> _applicationMapper;
        private readonly IMapper<Question, QuestionVm> _questionMapper;

        public ApplicationQuestionMapper(IMapper<Application, ApplicationVm> applicationMapper, IMapper<Question, QuestionVm> questionMapper)
        {
            _applicationMapper = applicationMapper;
            _questionMapper = questionMapper;
        }

        public ApplicationQuestion Map(ApplicationQuestionVm model)
        {
            ApplicationQuestion question = new ApplicationQuestion();

            question.Question = _questionMapper.Map(model.Question);

            question.Application = _applicationMapper.Map(model.Application);

            return question;
        }

        public ApplicationQuestionVm Map(ApplicationQuestion entity)
        {
            ApplicationQuestionVm question = new ApplicationQuestionVm();
            question.Id = entity.Id;

            question.Question = _questionMapper.Map(entity.Question);

            question.Application = _applicationMapper.Map(entity.Application);
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
