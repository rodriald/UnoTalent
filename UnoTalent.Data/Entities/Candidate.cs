namespace UnoTalent.Data.Entities.Abstractions
{
    class Candidate : IEntity
    {
        public override int Id { get; set; }
        public string Name { get; set; }
        public int ApplicationId { get; set; }
    }
}
