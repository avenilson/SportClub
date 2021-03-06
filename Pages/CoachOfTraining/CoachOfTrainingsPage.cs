﻿using System.Collections.Generic;
using System.Linq;
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
            Coaches= CreateSelectList2<Domain.Coach.Coach, CoachData>(c);
            TrainingId = CreateSelectList<Domain.Training.Training, TrainingData>(t);
        }
        public IEnumerable<SelectListItem> Coaches { get; }
        public IEnumerable<SelectListItem> TrainingId { get; }
        public override string ItemId => Item is null ? string.Empty : Item.GetId();
        public override string GetPageUrl() => "/CoachOfTraining/CoachOfTrainings";

        public override Domain.CoachOfTraining.CoachOfTraining ToObject(CoachOfTrainingView view)
            => CoachOfTrainingViewFactory.Create(view);

        public override CoachOfTrainingView ToView(Domain.CoachOfTraining.CoachOfTraining obj) 
            => CoachOfTrainingViewFactory.Create(obj);

        public string GetCoachName(string coaches)
        {
            foreach (var m in Coaches)
                if (m.Value == coaches)
                    return m.Text;

            return "";
        }
        public string GetTrainingName(string trainingId)
        {
            foreach (var m in TrainingId)
                if (m.Value == trainingId)
                    return m.Text;
            return "";
        }

        public override string GetPageSubTitle() 
            => FixedValue is null
                ? base.GetPageSubTitle()
                : $" {GetCoachName(FixedValue)}";
    }
}