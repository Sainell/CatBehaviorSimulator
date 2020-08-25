using UnityEngine;


namespace CatBehaviorSimulator
{
    public sealed class CatBehaviorController : MonoBehaviour
    {
        #region Fields

        private CatStateMachine _catStateMachine;

        #endregion


        #region UnityMethods

        private void Awake()
        {
            _catStateMachine = new CatStateMachine ();
            ButtonClick.ClickButtonEvent += CatInteraction;
        }

        private void Start()
        {
            _catStateMachine.State = new BadMoodState(_catStateMachine);
        }

        private void OnApplicationQuit()
        {
            ButtonClick.ClickButtonEvent -= CatInteraction;
        }

        #endregion


        #region Methods

        private void CatInteraction(string interaction)
        {
            switch (interaction)
            {
                case "ToPlay":
                    CatPlay();
                    break;
                case "ToFeed":
                    CatFeed();
                    break;
                case "ToPet":
                    CatPet();
                    break;
                case "ToKick":
                    CatKick();
                    break;
            }
        }

        private void CatPlay()
        {
            _catStateMachine.State.Play();
        }

        private void CatFeed()
        {
            _catStateMachine.State.Feed();
        }

        private void CatPet()
        {
            _catStateMachine.State.Pet();
        }

        private void CatKick()
        {
            _catStateMachine.State.Kick();
        }

        private BaseState GetMoodState ()
        {
            return _catStateMachine.State;
        }
        #endregion
    }
}