using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    public GameObject target;
    Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = new Vector3(0, 1, -3);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = target.transform.position + offset;
        transform.LookAt(target.transform);
        //transform.rotation = target.transform.rotation;
    }
}
