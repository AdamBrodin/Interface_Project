using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Developed by Adam Brodin
 * https://github.com/AdamBrodin
 */

[CreateAssetMenu(fileName = "Entity", menuName = "Entity")]
public class Entity : ScriptableObject
{
    string entityName, description;

    public float startHealth, currentHealth, moveSpeed;

    enum EntityType
    {
        Player,
        Enemy
    }
}
