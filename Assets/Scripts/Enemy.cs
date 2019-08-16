using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public GameObject waypointParent;
    public float waypointDistance = 0.2f;
    private Transform[] points;
    private int currentWaypoint = 1;
    private int speed = 5;
    public NavMeshAgent agent;


    // Start is called before the first frame update
    void Start()
    {
        //Gets the points from the way point parent
        points = waypointParent.GetComponentsInChildren<Transform>();
    }

    private void OnDrawGizmos()
    {
        //Draws a line in the editor for debugging
        points = waypointParent.GetComponentsInChildren<Transform>();
        if (points != null)
        {
            Gizmos.color = Color.red;
            for (int i = 0; i < points.Length - 1; i++)
            {
                Transform pointA = points[i];
                Transform pointB = points[i + 1];
                Gizmos.DrawLine(pointA.position, pointB.position);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (currentWaypoint != points.Length)
        {
            // get the current waypoint
            Transform currentPoints = points[currentWaypoint];
            //sets the destination for the next way point
            agent.SetDestination(currentPoints.position);
            //Calculates the distance and sets it to a float
            float distance = Vector3.Distance(transform.position, currentPoints.position);
            //When it reaches the waypoint it moves on to the next one
            if (distance < waypointDistance)
            {
                currentWaypoint++;
            }
        }
        else
        {
            currentWaypoint = 1;
        }
    }
}
