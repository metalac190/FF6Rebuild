using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Encounter
{
    public class HUDController : MonoBehaviour
    {
        [SerializeField] PartyHUD _partyHUD = null;
        [SerializeField] EnemyListHUD _enemyListHUD = null;
        [SerializeField] TextDisplayHUD _textDisplayHUD = null;
        [SerializeField] ActionMenuHUD _actionMenuHUD = null;
        [SerializeField] PauseHUD _pauseHUD = null;
        [SerializeField] ScreenFader _fader = null;

        public PartyHUD PartyHUD => _partyHUD;
        public EnemyListHUD EnemyListHUD => _enemyListHUD;
        public TextDisplayHUD TextDisplayHUD => _textDisplayHUD;
        public ActionMenuHUD ActionMenuHUD => _actionMenuHUD;
        public PauseHUD PauseHUD => _pauseHUD;
        public ScreenFader Fader => _fader;
    }
}

