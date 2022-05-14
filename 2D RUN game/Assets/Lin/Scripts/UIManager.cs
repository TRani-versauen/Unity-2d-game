using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Lin;

namespace Lin
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text roundTimerTxt = null;

        [SerializeField]
        private TMP_Text scoreTxt = null;

        private void LateUpdate()
        {
            roundTimerTxt.text = GamePlayManager.Instance.TimeLeft.ToString("00.00");
            scoreTxt.text = "Score : " + GamePlayManager.Instance.Score.ToString();
        }
    }

}