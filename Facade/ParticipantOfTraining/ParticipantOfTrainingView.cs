using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SportClub.Facade.ParticipantOfTraining
{
    public class ParticipantOfTrainingView
    {
        [Required]
        [DisplayName("Training")]

        public string TrainingId { get; set; }

        [Required]
        [DisplayName("Participant")]

        public string ParticipantId { get; set; }

        public string GetId()
        {
            return $"{ParticipantId}.{TrainingId}";
        }
    }
}
