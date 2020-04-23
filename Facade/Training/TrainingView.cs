using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SportClub.Facade.Common;

namespace SportClub.Facade.Training
{
    public sealed class TrainingView:NamedView
    {
        [Required]
        [DisplayName("Training")]

        public string Duration { get; set; }
        public string Definition { get; set; }
        public string ParticipantsCount { get; set; }

    }
}
