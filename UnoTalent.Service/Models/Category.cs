using System.Collections.Generic;

namespace UnoTalent.Service.Models
{
    public class CategoryVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<QuestionVm> Questions { get; set; }
    }
}
