using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    [Header("Enemy Stats")]
    public int health;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
            DestroyEnemy();
    }

    public void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}