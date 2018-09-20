using UnoTalent.Data.Entities.Abstractions;

namespace UnoTalent.Data.Entities
{
    public class ApplicationQuestion : IEntity
    {
        public int Id { get; set; }

        public Application Application { get; set; }

        public Question Question { get; set; }
    }
}
