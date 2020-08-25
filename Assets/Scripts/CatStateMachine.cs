using System;


namespace CatBehaviorSimulator
{
    public sealed class CatStateMachine
    {
        #region Fields

        private BaseState _state;
        public static event Action<BaseState> ChageStateEvent;

        #endregion


        #region Properties

        public BaseState State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                ChageStateEvent?.Invoke(_state);
            }
        }

        #endregion


        #region ClassLifeCycle
        
        public CatStateMachine()
        {
        }

        public CatStateMachine(BaseState state)
        {
            State = state;
        }

        #endregion
    }
}