using UnoTalent.Data.Entities.Abstractions;

namespace UnoTalent.Data.Entities
{
    public class Question : IEntity
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string CandidateQuestion { get; set; }

        public Category Category { get; set; }
    }
}
