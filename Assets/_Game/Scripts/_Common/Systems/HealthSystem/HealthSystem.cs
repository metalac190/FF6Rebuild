using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using System;

public class HealthSystem : IDamageable, IHealable
{
    public event Action<int> ChangedHealth = delegate { };
    public event Action<int> Damaged = delegate { };
    public event Action<int> Healed = delegate { };
    public event Action Killed = delegate { };

    int _currentHealth;

    public bool IsDamageable { get; set; }
    public int MaxHealth { get; private set; }
    public int CurrentHealth
    {
        get => _currentHealth;
        set
        {
            value = Mathf.Clamp(value, 0, MaxHealth);
            if (value != _currentHealth)
            {
                ChangedHealth?.Invoke(value);
            }
            _currentHealth = value;
        }
    }
    

    public HealthSystem(int startingHealth, int maxHealth)
    {
        MaxHealth = maxHealth;
        CurrentHealth = startingHealth;
    }

    public void Heal(int amount)
    {
        CurrentHealth += amount;
        Healed?.Invoke(amount);
    }

    public void TakeDamage(int amount)
    {
        if(IsDamageable)
        {
            CurrentHealth -= amount;
            Damaged?.Invoke(amount);
        }

        if (CurrentHealth <= 0 && IsDamageable)
        {
            Kill();
        }
    }

    public void Kill()
    {
        Killed?.Invoke();
    }
}
