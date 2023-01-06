using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EntityGold : MonoBehaviour
{
    [SerializeField] int _totalGold = 0;

    public event Action<int> GoldAdded;

    private void Start()
    {
        _totalGold = 0;
    }

    public void AddGold(int goldToAdd)
    {
        _totalGold += goldToAdd;
        GoldAdded.Invoke(_totalGold);
    }
}
