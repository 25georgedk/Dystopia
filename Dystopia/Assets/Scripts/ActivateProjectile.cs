using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateProjectile : MonoBehaviour
{
    public GameObject projectile;
    public KeyCode shootKey = KeyCode.Mouse0;
    public float shootCooldown;
    public bool readyToShoot;
    public Transform shootingPosition;

    // Update is called once per frame
    void Update()
    {
        transform.position = shootingPosition.position;
        if (Input.GetKey(shootKey) && readyToShoot)
        {
            readyToShoot = false;

            var clone = Instantiate(projectile, gameObject.transform.position, gameObject.transform.rotation);

            Invoke(nameof(ResetShoot), shootCooldown);

            Destroy(clone, 3.0f);
        }
    }
    private void ResetShoot()
    {
        readyToShoot = true;
    }
}
