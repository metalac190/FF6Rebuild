using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Encounter
{
    public class BattleSystem : MonoBehaviour
    {
        [SerializeField] TurnTracker _turnTracker;

        public TurnTracker TurnTracker => _turnTracker;
    }
}

