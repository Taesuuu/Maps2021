using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class move : MonoBehaviour
{
  

    NavMeshAgent agent;
    [SerializeField]
    Transform target;

    

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        
            agent.SetDestination(target.position);
         
    }

    
}
