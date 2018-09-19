using System;
using System.Collections.Generic;
using System.Text;
using UnoTalent.Data.Entities;
using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;

namespace UnoTalent.Service.Mappers
{
    class QuestionMapper : IMapper<Question, QuestionVm>
    {
        public Question Map(QuestionVm model)
        {
            Question question = new Question();
            question.Id = model.Id;
            question.Category = model.Category;
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
                Question newQuestion = new Question();
                newQuestion.Id = question.Id;
                newQuestion.CandidateQuestion = question.CandidateQuestion;
                questions.Add(newQuestion);
            }

            return questions;
        }

        public List<QuestionVm> Map(List<Question> entities)
        {
            List<QuestionVm> questions = new List<QuestionVm>();
            foreach (Question question in entities)
            {
                QuestionVm newQuestion = new QuestionVm();
                newQuestion.Id = question.Id;
                newQuestion.CandidateQuestion = question.CandidateQuestion;
                questions.Add(newQuestion);
            }

            return questions;
        }
    }
}
