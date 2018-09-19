namespace UnoTalent.Data.Entities
{
    public class ApplicationQuestion
    {
        public int Id { get; set; }
        public int? ApplicationId { get; set; }
        public int? QuestionId { get; set; }
    }
}
