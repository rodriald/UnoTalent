using UnoTalent.Data.Entities;

namespace UnoTalent.Service.Models
{
    public class ApplicationQuestionVm
    {
        public int Id { get; set; }
        public ApplicationVm Application { get; set; }
        public QuestionVm Question { get; set; }
    }
}
