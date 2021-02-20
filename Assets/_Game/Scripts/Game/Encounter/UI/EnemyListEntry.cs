using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace RPG.Encounter
{
    public class EnemyListEntry : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _labelView;

        Enemy _enemy;

        public void Display(Enemy enemy)
        {
            _enemy = enemy;

            _labelView.text = enemy.Name;
        }
    }
}

