using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject target;
    public GameObject bullet;
    public MoveToPosition player;
    public float ShootInterval = 1;
    public bool readyToShoot;
    public AudioSource ShootSound;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInChildren<MoveToPosition>();

        target = player.goal;

    }

    void Update()
    {
        if (readyToShoot)
        {
            readyToShoot = false;

            ShootSound.Play();

            var clone = Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);

            Invoke(nameof(ResetShoot), ShootInterval);

            Destroy(clone, 3.0f);
        }
    }
    private void ResetShoot()
    {
        readyToShoot = true;
    }
}
