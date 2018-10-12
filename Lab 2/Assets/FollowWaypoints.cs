using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWaypoints : MonoBehaviour {

    public int numWaypoints, current;
    public float radius, angle, speed;
    List<Vector3> points;

	// Use this for initialization
	void Start () {
        numWaypoints = 6;
        current = 0;
        radius = 6f;
        angle = 0f;
        speed = 10f;
        points = new List<Vector3>();

        for (int i = 0; i < numWaypoints; ++i)
        {
            float x = transform.position.x + Mathf.Cos(angle) * radius;
            float z = transform.position.z + Mathf.Sin(angle) * radius;
            points.Add(new Vector3(x, 0.5f, z));
            angle += Mathf.PI * 2 / numWaypoints;
        }
    }
	
	// Update is called once per frame
	void Update () {
        transform.forward = points[current] - transform.position;
        transform.position = Vector3.MoveTowards(transform.position, points[current], speed * Time.deltaTime);

        if(Vector3.Distance(transform.position, points[current]) < 1f)
        {
            current = (current + 1) % numWaypoints;
        }
	}

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        for (int i = 0; i < points.Count; ++i)
        {
            Gizmos.DrawWireSphere(points[i], 1);
        }
    }
}
