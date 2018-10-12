using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWall : MonoBehaviour {

    List<GameObject> blocks = new List<GameObject>();

    // Use this for initialization
    void Start () {

        float xOffset = 1f, yOffset = 2f;

        for(int i = 0; i < 10; ++i)
        {
            for(int j = 0; j < 10; ++j)
            {
                Color color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
                GameObject block = GameObject.CreatePrimitive(PrimitiveType.Cube);
                block.AddComponent<Rigidbody>();
                block.transform.position = new Vector3(i * xOffset, j * yOffset, 10);
                block.GetComponent<Renderer>().material.color = color;
                blocks.Add(block);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
