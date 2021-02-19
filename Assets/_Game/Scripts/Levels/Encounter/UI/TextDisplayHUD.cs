using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace RPG.Levels.Encounter
{
    public class TextDisplayHUD : MonoBehaviour
    {
        [SerializeField] RectTransform _textDisplayPanel;
        [SerializeField] TextMeshProUGUI _textView;

        private void Awake()
        {
            // ensure panel is off by default
            _textDisplayPanel.gameObject.SetActive(false);
        }

        public void Show()
        {
            _textDisplayPanel.gameObject.SetActive(true);
        }

        public void Hide()
        {
            _textDisplayPanel.gameObject.SetActive(false);
        }

        public void Display(string newText)
        {
            _textView.text = newText;
        }
    }
}

