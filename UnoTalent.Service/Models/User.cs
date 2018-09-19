using UnoTalent.Data.Entities.Abstractions;

namespace UnoTalent.Service.Models
{
    public class UserVm : IEntity
    {
        public override int Id { get; set; }
        public string Name { get; set; }
    }
}
