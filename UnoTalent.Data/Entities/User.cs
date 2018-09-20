using UnoTalent.Data.Entities.Abstractions;

namespace UnoTalent.Data.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
