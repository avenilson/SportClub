using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SportClub.Facade.Common;

namespace SportClub.Facade.CoachOfTraining
{
    public sealed class CoachOfTrainingView: NamedView
    {
        [Required]
        [DisplayName("Training")]

        public string TrainingId { get; set; }

        [Required]
        [DisplayName("Coach")]

        public string CoachId { get; set; }

        public string GetId()
        {
            return $"{CoachId}.{TrainingId}";
        }
    }
}
