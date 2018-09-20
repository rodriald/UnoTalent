using System.Collections.Generic;
using UnoTalent.Data.Entities.Abstractions;

namespace UnoTalent.Data.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Question> Questions { get; set; }
    }
}
