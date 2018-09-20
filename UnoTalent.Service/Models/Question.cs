using System;
using System.Collections.Generic;
using System.Text;
using UnoTalent.Data.Entities;
using UnoTalent.Data.Entities.Abstractions;

namespace UnoTalent.Service.Models
{
    public class QuestionVm
    {
        public int Id { get; set; }
        public string CandidateQuestion { get; set; }
    }
}
