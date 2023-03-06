using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float damageAmount = 1;
    void OnCollisionStay(Collision other)
    {
        if (other.transform.CompareTag("Player"))
        {
            SendMessage("ApplyDamage", damageAmount);
        }  
    }
}
