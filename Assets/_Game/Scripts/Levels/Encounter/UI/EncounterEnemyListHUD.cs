using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterEnemyListHUD : MonoBehaviour
{
    [SerializeField] RectTransform _enemyListPanel;
    [SerializeField] EncounterEnemyListEntry _enemyListEntryPrefab;
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
            EncounterEnemyListEntry newEnemyListEntry
                = Instantiate(_enemyListEntryPrefab, _enemyEntryLayoutPanel);

            newEnemyListEntry.Display(enemies[i]);
            newEnemyListEntry.gameObject.name = "EnemyEntry_" + i.ToString();
        }
    }
}
