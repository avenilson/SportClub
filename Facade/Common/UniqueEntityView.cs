using System.ComponentModel.DataAnnotations;

namespace SportClub.Facade.Common
{
    public abstract class UniqueEntityView
    {
        [Required]
        public string Id { get; set; }
    }
}
