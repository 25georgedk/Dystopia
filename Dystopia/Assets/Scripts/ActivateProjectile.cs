using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateProjectile : MonoBehaviour
{
    public GameObject projectile;
    public KeyCode shootKey = KeyCode.Mouse0;
    public float shootCooldown;
    public bool readyToShoot;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(shootKey))
        {
            readyToShoot = false;

            Invoke(nameof(ResetShoot), shootCooldown);

            var clone = Instantiate(projectile, gameObject.transform.position, gameObject.transform.rotation);

            Destroy(clone, 5.0f);
        }
    }
    private void ResetShoot()
    {
        readyToShoot = true;
    }
}
