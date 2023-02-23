using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 40.0f;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
