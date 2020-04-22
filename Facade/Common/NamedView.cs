using System.ComponentModel.DataAnnotations;

namespace SportClub.Facade.Common
{
    public abstract class NamedView: UniqueEntityView
    {
        [Required]
        public string Name { get; set; }
    }
}
