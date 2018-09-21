using System;
using System.Collections.Generic;
using System.Text;
using UnoTalent.Data.Entities;
using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;

namespace UnoTalent.Service.Mappers
{
    public class QuestionMapper : IMapper<Question, QuestionVm>
    {
        public Question Map(QuestionVm model)
        {
            Question question = new Question();
            question.Id = model.Id;
            question.CandidateQuestion = model.CandidateQuestion;
            return question;
        }

        public QuestionVm Map(Question entity)
        {
            QuestionVm question = new QuestionVm();
            question.Id = entity.Id;
            question.CandidateQuestion = entity.CandidateQuestion;
            
            return question;
        }

        public List<Question> Map(List<QuestionVm> models)
        {
            List<Question> questions = new List<Question>();
            foreach (QuestionVm question in models)
            {
                questions.Add(Map(question));
            }

            return questions;
        }

        public List<QuestionVm> Map(List<Question> entities)
        {
            List<QuestionVm> questions = new List<QuestionVm>();
            foreach (Question question in entities)
            {
                questions.Add(Map(question));
            }

            return questions;
        }

        public Question Map(Question entity, QuestionVm model)
        {
            throw new NotImplementedException();
        }
    }
}
