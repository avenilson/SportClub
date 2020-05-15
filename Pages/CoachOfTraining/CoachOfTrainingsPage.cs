﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportClub.Data.Coach;
using SportClub.Data.CoachOfTraining;
using SportClub.Data.Training;
using SportClub.Domain.Coach;
using SportClub.Domain.CoachOfTraining;
using SportClub.Domain.Training;
using SportClub.Facade.CoachOfTraining;

namespace SportClub.Pages.CoachOfTraining
{
    public abstract class CoachOfTrainingsPage : CommonPage<ICoachOfTrainingsRepository, Domain.CoachOfTraining.CoachOfTraining, CoachOfTrainingView, CoachOfTrainingData>
    {
        protected internal CoachOfTrainingsPage(ICoachOfTrainingsRepository r, ICoachesRepository c, ITrainingsRepository t) : base(r)
        {
            PageTitle = "Coach Of Trainings";
            CoachId= CreateSelectList2<Domain.Coach.Coach, CoachData>(c);
            TrainingId = CreateSelectList<Domain.Training.Training, TrainingData>(t);
            Ids = CreateSelectList3<Domain.Coach.Coach, CoachData>(c);
        }
        public IEnumerable<SelectListItem> CoachId { get; }
        public IEnumerable<SelectListItem> TrainingId { get; }
        public IEnumerable<SelectListItem> Ids { get; }

        public override string ItemId 
        {
            get
            {
                if (Item is null) return string.Empty;
                return $"{Item.CoachId}.{Item.TrainingId}";
            }
        }

        public override string GetPageUrl() => "/CoachOfTraining/CoachOfTrainings";

        public override Domain.CoachOfTraining.CoachOfTraining ToObject(CoachOfTrainingView view)
            => CoachOfTrainingViewFactory.Create(view);

        public override CoachOfTrainingView ToView(Domain.CoachOfTraining.CoachOfTraining obj) 
            => CoachOfTrainingViewFactory.Create(obj);

        public string GetCoachesId(string coachId)
        {
            foreach (var m in CoachId)
                if (m.Value == coachId)
                    return m.Text;

            return "";
        }

        public override string GetPageSubTitle() 
            => FixedValue is null
                ? base.GetPageSubTitle()
                : $" {GetCoachesId(FixedValue)}";
    }
}