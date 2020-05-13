using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SportClub.Facade.Common;

namespace SportClub.Facade.ParticipantOfTraining
{
    public sealed class ParticipantOfTrainingView:UniqueEntityView
    {
        [Required]
        [DisplayName("TrainingId")]

        public string TrainingId { get; set; }

        [Required]
        [DisplayName("ParticipantId")]

        public string ParticipantId { get; set; }

        public string GetId()=> $"{ParticipantId}.{TrainingId}";
        
    }
}
