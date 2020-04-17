using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SportClub.Facade.Quantity
{
    public class TrainingView
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }
        public string CoachName { get; set; } 
        [DataType(DataType.Date)] 
        [DisplayName("Starts")] 
        public DateTime? StartTime { get; set; }
        [DataType(DataType.Date)] 
        [DisplayName("Ends")] 
        public DateTime? EndTime { get; set; }
    }
}
