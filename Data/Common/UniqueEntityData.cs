using System.ComponentModel.DataAnnotations.Schema;

namespace SportClub.Data.Common
{
    public abstract class UniqueEntityData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
    }
}
