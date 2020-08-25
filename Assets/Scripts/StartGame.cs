using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


namespace CatBehaviorSimulator
{
    public sealed class StartGame : MonoBehaviour, IPointerClickHandler
    {

        #region UnityMethods

        public void OnPointerClick(PointerEventData eventData)
        {
            StartCoroutine(PreloadScene());
        }

        #endregion


        #region Methods

        IEnumerator PreloadScene()
        {
            AsyncOperation async = SceneManager.LoadSceneAsync(1);
            yield return async;
        }

        #endregion
    }
}