using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHealth : MonoBehaviour
{

    [SerializeField] int _maxHealth;
    
    public event Action<int> HealthChanged;
    public event Action TakeDmg;

    private int _currentHealth;

    private void Awake()
    {
        _currentHealth = _maxHealth;
        //HealthChanged.Invoke(CurrentHealth);
    }

    public int GetMaxHealth()
    {
        return _maxHealth;
    }

    public int GetCurrentHealth()
    {
        return _currentHealth;
    }

    public void Heal(int amountToHeal)
    {
        _currentHealth += amountToHeal;
        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
        HealthChanged.Invoke(_currentHealth);
    }

    public void TakeDamage(int v)
    {
        _currentHealth -= v;
        if (_currentHealth < 0)
        {
            _currentHealth = 0;
        }
        HealthChanged.Invoke(_currentHealth);
        TakeDmg.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DmgZone")
        {
            TakeDamage(20);
            Debug.Log("took damage?");
        }
    }
}
