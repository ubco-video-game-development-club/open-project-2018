﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    /// <summary>
    /// Ordered list of points that the enemy will path along.
    /// </summary>
    public Transform[] path;
    /// <summary>
    /// How close the player must be to a point on the path before being considered at that point.
    /// </summary>
    public float equivalenceDistance = 0.01f;
    /// <summary>
    /// Velocity at which the enemy will travel between points on the path.
    /// </summary>
    public float movementSpeed = 1f;

    /// <summary>
    /// Index of the current position in the list of points.
    /// </summary>
    private int pathIndex = 0;

    /// <summary>
    /// The last point on the path the enemy reached.
    /// </summary>
    private Vector3 prevPos;
    /// <summary>
    /// Point on the path the enemy is currently moving toward.
    /// </summary>
    private Vector3 targetPos;
    /// <summary>
    /// Interpolant used in Vector3.Lerp to smoothly move between points on the path. 
    /// Measures the percentage of the distance travelled.
    /// </summary>
    private float lerpDistance;
    /// <summary>
    /// Total time required to move between two points on the path at the defined movementSpeed.
    /// </summary>
    private float lerpDuration = 0;
    /// <summary>
    /// Timer of how long the enemy has been interpolating between two points.
    /// </summary>
    private float lerpTimer = 0;
    
	private void Start ()
    {
        transform.position = path[0].position;
        TargetNextPoint();
    }
	
	private void FixedUpdate ()
    {
        Move();
	}

    private void Move()
    {
        lerpTimer += Time.deltaTime;

        if (Vector3.Distance(targetPos, transform.position) < equivalenceDistance)
        {
            lerpTimer = 0;
            TargetNextPoint();
        }

        lerpDistance = lerpTimer / lerpDuration;
        transform.position = Vector3.Lerp(prevPos, targetPos, lerpDistance);
    }

    private void TargetNextPoint()
    {
        pathIndex++;
        if (pathIndex == path.Length)
        {
            Destroy(gameObject);
            return;
        }
        prevPos = path[pathIndex - 1].position;
        targetPos = path[pathIndex].position;
        lerpDuration = Vector3.Distance(prevPos, targetPos) / movementSpeed;
    }
}