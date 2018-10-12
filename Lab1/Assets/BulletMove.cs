using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

    public GameObject bullet;
    float elapsedTime = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, 10 * Time.deltaTime);

        elapsedTime += Time.deltaTime;

        if(elapsedTime >= 5)
        {
            Destroy(bullet);
        }
	}
}
