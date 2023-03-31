using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPosition : MonoBehaviour
{
    public float moveSpeed;

    public float groundDrag;
    Rigidbody rb;
    public GameObject goal;
    private UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(goal.transform.position);
       
        rb.drag = groundDrag;
        
    }
}
