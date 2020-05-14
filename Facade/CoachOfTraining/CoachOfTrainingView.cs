using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SportClub.Facade.Common;

namespace SportClub.Facade.CoachOfTraining
{
    public sealed class CoachOfTrainingView: UniqueEntityView
    {
        [Required]
        [DisplayName("Coach")]
        public string CoachId { get; set; }

        [Required]
        [DisplayName("Training")]
        public string TrainingId { get; set; }

        public string GetId() => $"{CoachId}.{TrainingId}";
    }
}
