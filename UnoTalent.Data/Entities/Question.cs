using UnoTalent.Data.Entities.Abstractions;

namespace UnoTalent.Data.Entities
{
    public class Question : IEntity
    {
        public override int Id { get; set; }
        public Category Category { get; set; }
        public string CandidateQuestion { get; set; }
    }
}
