using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using TMPro;

public class GoldUI : MonoBehaviour
{
    [SerializeField] EntityGold _entityGold;

    TextMeshProUGUI _goldText;

    
    void Start()
    {
        _entityGold.GoldAdded += UpdateGoldUI;
        _goldText = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void OnDestroy()
    {
        _entityGold.GoldAdded -= UpdateGoldUI;
    }

    void UpdateGoldUI(int goldToDisplay)
    {
        _goldText.text = "Gold: " + goldToDisplay.ToString();
        Debug.Log("GoldUI Update");
    }
}
