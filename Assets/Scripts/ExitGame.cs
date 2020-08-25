using UnityEngine;
using UnityEngine.EventSystems;


namespace CatBehaviorSimulator
{
    public sealed class ExitGame : MonoBehaviour, IPointerClickHandler
    {

        #region UnityMethods

        public void OnPointerClick(PointerEventData eventData)
        {
            Exit();
        }

        #endregion


        #region Methods

        private void Exit()
        {
            Application.Quit();
        }

        #endregion
    }
}