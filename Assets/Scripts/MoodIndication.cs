using UnityEngine;
using UnityEngine.UI;


namespace CatBehaviorSimulator
{
    public sealed class MoodIndication : MonoBehaviour
    {
        #region Fields
        public const float BAD_MOOD_AMOUNT = 0.1f;
        public const float GOOD_MOOD_AMOUNT = 0.5f;
        public const float GREAT_MOOD_AMOUNT = 1f;

        public Image MoodImg;
        public Text MoodText;

        #endregion


        #region UnityMethods

        private void Awake()
        {
            CatStateMachine.ChageStateEvent += ChangeMood;
        }

        private void OnApplicationQuit()
        {
            CatStateMachine.ChageStateEvent -= ChangeMood;
        }

        #endregion


        #region Methods

        private void ChangeMood(BaseState currentMoodState)
        {
            var stateName = currentMoodState.GetType().Name;
            
            if (stateName.Equals("BadMoodState"))
            {
                MoodImg.fillAmount = BAD_MOOD_AMOUNT;
                MoodImg.color = Color.red;
                MoodText.text = "Плохое настроение";
            }
            if (stateName.Equals("GoodMoodState"))
            {
                MoodImg.fillAmount = GOOD_MOOD_AMOUNT;
                MoodImg.color = Color.yellow;
                MoodText.text = "Хорошее настроение";
            }
            if (stateName.Equals("GreatMoodState"))
            {
                MoodImg.fillAmount = GREAT_MOOD_AMOUNT;
                MoodImg.color = Color.green;
                MoodText.text = "Отличное настроение";
            }
        }

        #endregion

    }
}