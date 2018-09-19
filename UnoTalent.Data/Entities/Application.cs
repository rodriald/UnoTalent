using System;
using System.Collections.Generic;
using System.Text;
using UnoTalent.Data.Entities.Abstractions;

namespace UnoTalent.Data.Entities
{
    class Application : IEntity
    {
        public override int Id { get; set; }
        public int CandidateId { get; set; }
    }
}
