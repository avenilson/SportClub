using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SportClub.Facade.Common;

namespace SportClub.Facade.CoachOfTraining
{
    public sealed class CoachOfTrainingView: NamedView
    {
        [Required]
        [DisplayName("CoachId")]

        public string CoachId { get; set; }
        [Required]
        [DisplayName("TrainingId")]

        public string TrainingId { get; set; }

        public string GetId()
        {
            return $"{CoachId}.{TrainingId}";
        }
    }
}
