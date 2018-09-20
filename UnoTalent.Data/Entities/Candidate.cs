using UnoTalent.Data.Entities.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnoTalent.Data.Entities
{

    public class Candidate : IEntity
    {
        [Key, ForeignKey("Application")]
        public int Id { get; set; }

        public string Name { get; set; }

        public Application Application { get; set; }

    }
}
