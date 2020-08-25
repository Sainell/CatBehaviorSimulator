namespace CatBehaviorSimulator
{
    public sealed class BadMoodState : BaseState
    {
        #region ClassLifeCycle

        public BadMoodState(CatStateMachine stateMachine) : base(stateMachine)
        {
        }

        #endregion


        #region Methods

        public override void Feed()
        {
            _reaction = "Все съедает, но если в это время подойти - поцарапает";
            CallCatReactionEvent();
            _stateMachine.State = new GoodMoodState(_stateMachine);
        }

        public override void Kick()
        {
            _reaction = "Прыгает и кусает за правое ухо";
            CallCatReactionEvent();
        }

        public override void Pet()
        {
            _reaction = "Царапает";
            CallCatReactionEvent();
        }

        public override void Play()
        {
            _reaction = "Сидит на месте";
            CallCatReactionEvent();
        }

        #endregion
    }
}