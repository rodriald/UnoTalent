using System;
using System.Collections.Generic;
using System.Text;
using UnoTalent.Data.Entities;
using UnoTalent.Data.Entities.Abstractions;

namespace UnoTalent.Service.Models
{
    public class CandidateVm : IEntity
    {
        public override int Id { get; set; }
        public string Name { get; set; }
        public Application Application { get; set; }
    }
}
