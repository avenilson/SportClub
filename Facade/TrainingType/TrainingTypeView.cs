using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SportClub.Facade.Common;

namespace SportClub.Facade.TrainingType
{
    public sealed class TrainingTypeView:UniqueEntityView
    {
        [Required]
        [DisplayName("Training Type")]
        public string Type { get; set; }
    }
}
