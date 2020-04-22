using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SportClub.Facade.Common;

namespace SportClub.Facade.ParticipantOfTraining
{
    public sealed class ParticipantOfTrainingView:NamedView
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
