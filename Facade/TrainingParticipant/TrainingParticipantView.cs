using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SportClub.Facade.TrainingParticipant
{
    public class TrainingParticipantView
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
