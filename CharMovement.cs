using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class pathfinder : MonoBehaviour
{
    public NavMeshAgent myAgent;

    public GameObject target;
    
    void Start()
    {
        myAgent.SetDestination(target.transform.position);
    }

    
    void Update()
    {
        
    }
}
