using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterActionMenuHUD : MonoBehaviour
{
    [SerializeField] RectTransform _actionMenuPanel;
    // action menu items

    private void Awake()
    {
        _actionMenuPanel.gameObject.SetActive(false);
    }

    public void Show()
    {
        _actionMenuPanel.gameObject.SetActive(true);
    }

    public void Hide()
    {
        _actionMenuPanel.gameObject.SetActive(false);
    }
}
