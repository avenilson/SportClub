using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SportClub.Facade.Common;

namespace SportClub.Facade.Participant
{
    public sealed class ParticipantView: NamedView
    {
        [Required]
        [DisplayName("Age")]
        [Range(18, 90, ErrorMessage = "Customer {0} should be in {1} to {2} range.")] 
        public string Age { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Address { get; set; }
    }
}
