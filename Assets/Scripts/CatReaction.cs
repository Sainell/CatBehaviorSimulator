using UnityEngine;
using UnityEngine.UI;


namespace CatBehaviorSimulator
{
    public sealed class CatReaction : MonoBehaviour
    {
        #region Fields

        public Text Description;

        #endregion


        #region UnityMethods

        private void Awake()
        {
            BaseState.CatReactionEvent += SetDescription;
        }

        private void OnApplicationQuit()
        {
            BaseState.CatReactionEvent -= SetDescription;   
        }

        #endregion


        #region Methods

        private void SetDescription(string description)
        {
            Description.text = description;
        }

        #endregion
    }
}