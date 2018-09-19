using UnoTalent.Data.Entities;

namespace UnoTalent.Service.Models
{
    public class ApplicationQuestionVm
    {
        public int Id { get; set; }
        public Application Application { get; set; }
        public Question Question { get; set; }
    }
}
