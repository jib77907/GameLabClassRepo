using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinBounce : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    float speed = 8f;
    float height = 0.5f;

	// Update is called once per frame
	void Update () {
        //transform.Rotate (0,0, Time.deltaTime * 100);  //last arg = makes it rotate from the z axis
        //transform.Translate((Vector2.up *  Mathf.Sin(Time.time*10)/80));
        Vector2 pos = transform.position;
        float newY = Mathf.Sin(Time.time * speed) *0.25f;  //inside() = speed(altitude), outside() = height(magnitude)
        transform.position = new Vector2(pos.x, newY);
	}
}
