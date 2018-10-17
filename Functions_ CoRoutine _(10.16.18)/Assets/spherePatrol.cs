using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherePatrol : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Vector3.Lerp(Start position, end position, postion in between 0-1);
        transform.position = Vector3.Lerp(new Vector3(-10f, 0f, 0f), new Vector3(10f, 0f, 0f), Mathf.PingPong(Time.time/7, 1));
	}
}
