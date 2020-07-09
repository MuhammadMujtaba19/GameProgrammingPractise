using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class pathfinding : MonoBehaviour
{
    public Transform[] points;
    int destpoint = 0;
    NavMeshAgent nav;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate() {
        if (!nav.pathPending && nav.remainingDistance < 0.5f){
            gotonext();
        }
    }
    void gotonext(){
        nav.destination = points[destpoint].position;
        destpoint = (destpoint + 1)%points.Length;
    }

}
