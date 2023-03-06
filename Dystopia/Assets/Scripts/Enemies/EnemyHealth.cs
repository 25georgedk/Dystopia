using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int hitNumber;
    public float hitToKill = 3;
   
    void OnTriggerEnter(Collider hit)
    {
        if (hit.transform.CompareTag("Projectile"))
        {
          hitNumber++;
        }
        if (hitNumber == hitToKill)
        {
          Destroy(gameObject);
        }
    }
}
