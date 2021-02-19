using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Levels.Encounter
{
    public class EnemyListHUD : MonoBehaviour
    {
        [SerializeField] RectTransform _enemyListPanel;
        [SerializeField] EnemyListEntry _enemyListEntryPrefab;
        [SerializeField] Transform _enemyEntryLayoutPanel;

        private void Awake()
        {
            // ensure disabled is the default state
            _enemyListPanel.gameObject.SetActive(false);
        }

        public void Show()
        {
            _enemyListPanel.gameObject.SetActive(true);
        }

        public void Hide()
        {
            _enemyListPanel.gameObject.SetActive(false);
        }

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

