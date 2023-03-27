using System.Collections;
using System.Collections.Generic;
using UnityEngine;



 public class PlayerHealth : MonoBehaviour
 {
    public int Health = 100;
    public float Iframes;
    private EnemyDamage enemy;
    public bool wasAttacked;

    private void Start()
    {
        enemy = FindObjectOfType<EnemyDamage>();
    }

    public void OnCollisionEnter(Collision attacked)
    {
        if (attacked.gameObject.CompareTag("Enemy") && wasAttacked == false)
        {
            wasAttacked = true;
            Health -= enemy.AttackDamage;

            Invoke(nameof(ResetDamage), Iframes);
        }
    }

    private void ResetDamage()
    {
        wasAttacked = false;
    }

    public void Update()
    {
        if (Health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);

        Debug.Log("Game Over");
    }
 }

