using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField] private float _currentHealth;

    [SerializeField] private float _maximunhealth;

    public float RemainingHealthPercentage
    {
        get
        {
            return _currentHealth / _maximunhealth;
        }
    }

    public void TakeDamage(float damageAmount)
    {
        if (_currentHealth == 0)
        {
            return;
        }
        _currentHealth -= damageAmount;

        if (_currentHealth < 0)
        {
            _currentHealth = 0;
        }
    }

    public void AddHealth(float amountToAdd)
    {
        if (_currentHealth == _maximunhealth)
        {
            return;
        }

        _currentHealth += amountToAdd;

        if (_currentHealth > _maximunhealth)
        {
            _currentHealth = _maximunhealth;
        }
    }
}
