using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SportClub.Facade.Common;

namespace SportClub.Facade.TrainingType
{
    public sealed class TrainingTypeView:NamedView
    {
        [Required]
        [DisplayName("Training Type")]
        public string Type { get; set; }

        [Required]
        [DisplayName("Definition")]
        public string Definition { get; set; }
    }
}
