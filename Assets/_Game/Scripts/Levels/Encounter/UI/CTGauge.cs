using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RPG.Levels.Encounter
{
    public class CTGauge : MonoBehaviour
    {
        [SerializeField] Image _fillImageView;

        public void SetScale(float newAmount, float maxAmount)
        {
            float newXScale = (1 / maxAmount) * newAmount;
            newXScale = Mathf.Clamp(newXScale, 0, 1);
            _fillImageView.transform.localScale = new Vector3(newXScale, 1, 1);
        }
    }
}

