using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour
{
    public float Damage = 10f;
    public float speed = 10.0f;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
        else if (hit.gameObject.tag == "Enemy")
        {
            Destroy(hit.gameObject);
            Destroy(gameObject);
        }
    }
}
