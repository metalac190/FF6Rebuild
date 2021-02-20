using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace RPG.Encounter
{
    public class TextDisplayHUD : HUD
    {
        [Header("Text Display")]
        [SerializeField] TextMeshProUGUI _textView;

        public void Display(string newText)
        {
            _textView.text = newText;
        }
    }
}

