using System;
using System.Collections.Generic;
using System.Text;
using UnoTalent.Data.Entities.Abstractions;

namespace UnoTalent.Data.Entities
{
    class Question : IEntity
    {
        public override int Id { get; set; }
        public int CategoryId { get; set; }
        public string CandidateQuestion { get; set; }
    }
}
