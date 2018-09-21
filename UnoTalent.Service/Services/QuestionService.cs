using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnoTalent.Data;
using UnoTalent.Data.Entities;
using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;
using UnoTalent.Service.Services.Abstractions;

namespace UnoTalent.Service.Services
{
    public class QuestionService : ApiService<Question, QuestionVm>
    {
        public QuestionService(IMapper<Question, QuestionVm> mapper, UnoTalentDbContext context) : base(mapper, context)
        {
            
        }

        public override QuestionVm GetById(int id)
        {
            var entity = _context.Questions.Find(id);

            return _mapper.Map(entity);
        }
    }
}
