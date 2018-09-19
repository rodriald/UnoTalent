using System;
using System.Collections.Generic;
using System.Text;
using UnoTalent.Data.Entities;
using UnoTalent.Data.Entities.Abstractions;

namespace UnoTalent.Service.Models
{
    public class Question : IEntity
    {
        public override int Id { get; set; }
        public Category Category { get; set; }
        public string CandidateQuestion { get; set; }
    }
}
