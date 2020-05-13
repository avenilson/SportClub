using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportClub.Data.Participant;
using SportClub.Data.ParticipantOfTraining;
using SportClub.Data.Training;
using SportClub.Domain.Participant;
using SportClub.Domain.ParticipantOfTraining;
using SportClub.Domain.Training;
using SportClub.Facade.ParticipantOfTraining;

namespace SportClub.Pages.ParticipantOfTraining
{
    public abstract class ParticipantOfTrainingsPage : CommonPage<IParticipantOfTrainingsRepository, Domain.ParticipantOfTraining.ParticipantOfTraining, ParticipantOfTrainingView, ParticipantOfTrainingData>
    {
        protected internal ParticipantOfTrainingsPage(IParticipantOfTrainingsRepository r, IParticipantsRepository p, ITrainingsRepository t) : base(r)
        {
            PageTitle = "Participant Of Trainings";
            ParticipantId = CreateSelectList2<Domain.Participant.Participant, ParticipantData>(p);
            TrainingId = CreateSelectList<Domain.Training.Training, TrainingData>(t);

        }
        public IEnumerable<SelectListItem> ParticipantId { get; }
        public IEnumerable<SelectListItem> TrainingId { get; }


        public override string ItemId 
        {
            get
            {
                if (Item is null) return string.Empty;
                return $"{Item.ParticipantId}.{Item.TrainingId}";
            }
        }

        public override string GetPageUrl() => "/ParticipantOfTraining/ParticipantOfTrainings";

        public override Domain.ParticipantOfTraining.ParticipantOfTraining ToObject(ParticipantOfTrainingView view)
        {
            return ParticipantOfTrainingViewFactory.Create(view);
        }

        public override ParticipantOfTrainingView ToView(Domain.ParticipantOfTraining.ParticipantOfTraining obj)
        {
            return ParticipantOfTrainingViewFactory.Create(obj);
        }
        public string GetParticipantId(string participantId)
        {
            foreach (var m in ParticipantId)
                if (m.Value == participantId)
                    return m.Text;

            return "";
        }

        public override string GetPageSubTitle()
        {
            return FixedValue is null
                ? base.GetPageSubTitle()
                : $"{GetParticipantId(FixedValue)}";
        }

    }

}