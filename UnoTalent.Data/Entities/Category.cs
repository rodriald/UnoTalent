﻿using System;
using System.Collections.Generic;
using System.Text;
using UnoTalent.Data.Entities.Abstractions;

namespace UnoTalent.Data.Entities
{
    class Category : IEntity
    {
        public override int Id { get; set; }
        public string Name { get; set; }
        public List<Question> Questions { get; set; }
    }
}
