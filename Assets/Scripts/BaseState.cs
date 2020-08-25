using System;


namespace CatBehaviorSimulator
{
    public abstract class BaseState
    {
        #region Fields

        public static event Action<string> CatReactionEvent;
        protected CatStateMachine _stateMachine;
        protected string _reaction;

        #endregion


        #region ClassLifeCycle

        public BaseState (CatStateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }

        #endregion


        #region Methods

        protected void CallCatReactionEvent()
        {
            CatReactionEvent?.Invoke(_reaction);
        }

        public abstract void Play();
        public abstract void Feed();
        public abstract void Pet();
        public abstract void Kick();

        #endregion
    }
}