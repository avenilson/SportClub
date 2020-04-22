using System;
using System.Collections.Generic;
using System.Text;
using SportClub.Data.TrainingType;
using SportClub.Domain.TrainingType;

namespace SportClub.Infra.TrainingType
{
    public sealed class TrainingTypesRepository : UniqueEntityRepository<Domain.TrainingType.TrainingType, TrainingTypeData>, ITrainingTypesRepository
    {
        public TrainingTypesRepository(SportClubDbContext c) : base(c, c.TrainingTypes) { }

        protected internal override Domain.TrainingType.TrainingType ToDomainObject(TrainingTypeData d) => new Domain.TrainingType.TrainingType(d);
    }
}
