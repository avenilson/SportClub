using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SportClub.Facade.Common;

namespace SportClub.Facade.Training
{
    public sealed class TrainingView:NamedView
    {
        [Required]
        [DisplayName("Duration")]
        [Range(30, 90, ErrorMessage = "Training duration should be in 30 to 90 range.")]
        public string Duration { get; set; }

        public string Definition { get; set; }

        [DisplayName("Participants Count")]
        [Range(10, 35, ErrorMessage = "Training participants count should be in 10 to 35 range.")]
        public string ParticipantsCount { get; set; }

    }
}
