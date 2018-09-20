using UnoTalent.Data.Entities.Abstractions;

namespace UnoTalent.Service.Models
{
    public class UserVm : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
