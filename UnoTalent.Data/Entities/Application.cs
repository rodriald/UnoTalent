using UnoTalent.Data.Entities.Abstractions;

namespace UnoTalent.Data.Entities
{
    public class Application : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Candidate Candidate { get; set; }
    }
}
