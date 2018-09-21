using System.Collections.Generic;

namespace UnoTalent.Service.Models
{
    public class ApplicationVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CandidateVm Candidate { get; set; }
        public List<QuestionVm> Questions { get; set; }
    }
}
