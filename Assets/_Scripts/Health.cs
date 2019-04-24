using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Developed by Adam Brodin
 * https://github.com/AdamBrodin
 */

public class Health : MonoBehaviour, IKillable<float>
{
    #region Variables
    public float StartHealth { get => startHP; set => startHP = value; }
    public float CurrentHealth { get => currentHP; set => currentHP = value; }

    [SerializeField]
    private float startHP, currentHP;
    #endregion

    private void Start()
    {
        if (GetComponent<Entity>() != null)
        {
            Entity e = GetComponent<Entity>();

            StartHealth = e.startHealth;
            CurrentHealth = StartHealth;
        }
    }

    public void CheckIfDead()
    {
        if (CurrentHealth <= 0)  // If dead
        {
            Die();
        }
    }

    public void Die()
    {
        print("Dead.");
    }

    public void TakeDamage(float damage)
    {
        CurrentHealth -= damage;
    }

    // Make sure the function/variable values remain the same
    private void OnValidate()
    {
        StartHealth = startHP;
        CurrentHealth = currentHP;
    }
}
