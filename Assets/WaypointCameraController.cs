using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WaypointCameraController : MonoBehaviour
{
    public Transform[] waypoints;

    public float speed; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direction = waypoints[0].position - transform.position;

        transform.position = transform.position + direction * speed * Time.deltaTime;   
    }
}
