using System.ComponentModel.DataAnnotations;

namespace SportClub.Facade.Common
{
    public abstract class NamedView: UniqueEntityView
    {
        [Required]
        [StringLength(20, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 3)]
        public string Name { get; set; }
    }
}
