using System;
using System.Collections.Generic;
using System.Text;

namespace UnoTalent.Data.Entities.Abstractions
{
    public abstract class IEntity
    {
        abstract public int Id { get; set; }
    }
}
