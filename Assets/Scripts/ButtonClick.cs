using System;
using UnityEngine;
using UnityEngine.EventSystems;


namespace CatBehaviorSimulator
{
    public sealed class ButtonClick : MonoBehaviour, IPointerClickHandler
    {
        #region Fields

        public static event Action<string> ClickButtonEvent;

        #endregion


        #region Methods

        public void OnPointerClick(PointerEventData eventData)
        {
            ClickButtonEvent?.Invoke(eventData.pointerPress.name);
        }

        #endregion 
    }
}