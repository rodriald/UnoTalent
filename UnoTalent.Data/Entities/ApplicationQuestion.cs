namespace UnoTalent.Data.Entities
{
    public class ApplicationQuestion
    {
        public int Id { get; set; }
        public Application Application { get; set; }
        public Question Question { get; set; }
    }
}
