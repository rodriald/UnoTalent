using UnoTalent.Data.Entities.Abstractions;

namespace UnoTalent.Data.Entities
{

    public class Candidate : IEntity
    {
        public override int Id { get; set; }
        public string Name { get; set; }
        public Application Application { get; set; }
    }
}
