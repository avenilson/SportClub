using SportClub.Domain.ParticipantOfTraining;
using SportClub.Facade.ParticipantOfTraining;

namespace SportClub.Pages.ParticipantOfTraining
{
    public abstract class ParticipantOfTrainingsPage : CommonPage<IParticipantOfTrainingsRepository, Domain.ParticipantOfTraining.ParticipantOfTraining, ParticipantOfTrainingView, ParticipantOfTrainingsPage>
    {
        protected internal ParticipantOfTrainingsPage(IParticipantOfTrainingsRepository r) : base(r)
        {
            PageTitle = "Participant Of Trainings";
        }

        public override string ItemId => Item.Id;

        public override string GetPageUrl() => "/ParticipantOfTraining/ParticipantOfTrainings";

        public override Domain.ParticipantOfTraining.ParticipantOfTraining ToObject(ParticipantOfTrainingView view)
        {
            return ParticipantOfTrainingViewFactory.Create(view);
        }

        public override ParticipantOfTrainingView ToView(Domain.ParticipantOfTraining.ParticipantOfTraining obj)
        {
            return ParticipantOfTrainingViewFactory.Create(obj);
        }

    }

}