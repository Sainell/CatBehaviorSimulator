namespace CatBehaviorSimulator
{
    public sealed class GreatMoodState : BaseState
    {
        #region ClassLifeCycle

        public GreatMoodState(CatStateMachine stateMachine) : base(stateMachine)
        {
        }

        #endregion


        #region Methods

        public override void Feed()
        {
            _reaction = "Быстро все съедает";
            CallCatReactionEvent();
        }

        public override void Kick()
        {
            _reaction = "Убегает в другую комнату";
            CallCatReactionEvent();
            _stateMachine.State = new BadMoodState(_stateMachine);
        }

        public override void Pet()
        {
            _reaction = "Мурлычет и виляет хвостом";
            CallCatReactionEvent();
        }

        public override void Play()
        {
            _reaction = "Носится, как угорелая";
            CallCatReactionEvent();
        }

        #endregion
    }
}