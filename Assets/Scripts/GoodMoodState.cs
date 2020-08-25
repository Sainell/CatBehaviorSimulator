namespace CatBehaviorSimulator
{
    public sealed class GoodMoodState : BaseState
    {
        #region ClassLifeCycle

        public GoodMoodState(CatStateMachine stateMachine) : base(stateMachine)
        {
        }

        #endregion


        #region Methods

        public override void Feed()
        {
            _reaction = "Быстро все съедает";
            CallCatReactionEvent();
            _stateMachine.State = new GreatMoodState(_stateMachine);
        }

        public override void Kick()
        {
            _reaction = "Убегает на ковер и писает";
            CallCatReactionEvent();
            _stateMachine.State = new BadMoodState(_stateMachine);
        }

        public override void Pet()
        {
            _reaction = "Мурлычет";
            CallCatReactionEvent();
            _stateMachine.State = new GreatMoodState(_stateMachine);
        }

        public override void Play()
        {
            _reaction = "Медленно бегает за мячиком";
            CallCatReactionEvent();
            _stateMachine.State = new GreatMoodState(_stateMachine);
        }

        #endregion
    }
}