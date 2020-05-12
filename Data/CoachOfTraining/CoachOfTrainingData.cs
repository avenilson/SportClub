using System;
using System.ComponentModel.DataAnnotations;
using SportClub.Data.Common;

namespace SportClub.Data.CoachOfTraining
{
    public sealed class CoachOfTrainingData:UniqueEntityData
    {
        public CoachOfTrainingData()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public new Guid Id { get; set; }
        public string CoachId { get; set; }
        public string TrainingId { get; set; }
    }
}
