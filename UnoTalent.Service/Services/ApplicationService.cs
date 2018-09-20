using Microsoft.EntityFrameworkCore;
using UnoTalent.Service.Services.Abstractions;
using UnoTalent.Data.Entities;
using UnoTalent.Data;
using System.Linq;

using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;
using UnoTalent.Service.Mappers;

namespace UnoTalent.Service.Services
{
    public class ApplicationService : ApiService<Application, ApplicationVm>
    {
        public ApplicationService(IMapper<Application, ApplicationVm> mapper, UnoTalentDbContext context) : base(mapper, context)
        {
        }

        public override ApplicationVm GetById(int id)
        {
            var application = _mapper.Map(_context.Applications.Include(x => x.Candidate).SingleOrDefault(x => x.Id == id));

            IMapper<ApplicationQuestion, ApplicationQuestionVm> mapper = new ApplicationQuestionMapper();
            var questions = mapper.Map(_context.ApplicationQuestions.Include(x => x.Question).Include(y => y.Application).ToList());
            foreach (var question in questions)
            {
                application.Questions.Add(question.Question);
            }

            return application;
        }

        public override ApplicationVm Update(int id, ApplicationVm item)
        {
            var application = _context.Applications.Find(id);
            
            ApplicationVm newItem = _mapper.Map(application);
            newItem.Id = item.Id;
            newItem.Name = item.Name;

            _context.Applications.Update(_mapper.Map(newItem));
            _context.SaveChanges();
            return newItem;
        }
    }
}
