using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Encounter
{
    public class EnemyListHUD : HUD
    {
        [Header("Enemy List")]
        [SerializeField] EnemyListEntry _enemyListEntryPrefab;
        [SerializeField] Transform _enemyEntryLayoutPanel;

        public void CreateEnemyListHUD(List<Enemy> enemies)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                EnemyListEntry newEnemyListEntry
                    = Instantiate(_enemyListEntryPrefab, _enemyEntryLayoutPanel);

                newEnemyListEntry.Display(enemies[i]);
                newEnemyListEntry.gameObject.name = "EnemyEntry_" + i.ToString();
            }
        }
    }
}

