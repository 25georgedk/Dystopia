using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int AttackDamage;

    public PlayerHealth player;

    public void Start()
    {
        player = FindObjectOfType<PlayerHealth>();
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DealDamage();
        }
    }

    public void DealDamage()
    {
        player.curHealth -= AttackDamage;
    }
}