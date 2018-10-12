using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour {
    public GameObject bulletPrefab;
    public GameObject spawnPoint;

    public float speed;
    public float rotateSpeed;

	// Use this for initialization
	void Start ()
    {
        speed = 10.0f;
        rotateSpeed = 100.0f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = GameObject.Instantiate(bulletPrefab);
            bullet.transform.position = spawnPoint.transform.position;
            bullet.transform.rotation = spawnPoint.transform.rotation;
        }

        //GameObject newObject = GameObject.Instantiate(prefab);
        //transform.Translate(0, 1, 0);
    }
}
