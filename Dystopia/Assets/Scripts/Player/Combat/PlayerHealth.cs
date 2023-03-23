using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int Health = 100;
    public bool wasAttacked;
    public float Iframes;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && wasAttacked == false)
        {
            wasAttacked = true;
            Health -= 10;

            Invoke(nameof(ResetDamage), Iframes);
        }
    }

    private void ResetDamage()
    {
        wasAttacked = false;
    }
}
