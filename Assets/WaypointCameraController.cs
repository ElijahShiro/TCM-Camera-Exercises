using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WaypointCameraController : MonoBehaviour
{
    public Transform[] waypoints;

    private int currentWaypoint;
    public float speed; 
    void Start()
    {
        currentWaypoint = 0;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direction = waypoints[currentWaypoint].position - transform.position;

        direction = direction.normalized;

        transform.position = transform.position + direction * speed * Time.deltaTime;   

        if(transform.position == waypoints[currentWaypoint].position)
        {
            currentWaypoint += 1;
        }
        
    }
}
