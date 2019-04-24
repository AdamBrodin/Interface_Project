using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IKillable<T>
{
    float StartHealth { get; set; }
    float CurrentHealth { get; set; }

    void CheckIfDead();
    void Die();
    void TakeDamage(T damage);
}
