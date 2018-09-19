using System;
using System.Collections.Generic;
using System.Text;
using UnoTalent.Data.Entities.Abstractions;

namespace UnoTalent.Service.Models
{
    public class ApplicationVm : IEntity
    {
        public override int Id { get; set; }
        public string Name { get; set; }
    }
}
