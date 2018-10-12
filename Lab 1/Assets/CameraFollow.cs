using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public GameObject target;
    public GameObject tank;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = target.transform.position;
        position.z -= 10;
        position.y += 5;
        transform.position = Vector3.Lerp(transform.position, position, Time.deltaTime);
        //transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime);
        transform.LookAt(tank.transform);
	}
}
