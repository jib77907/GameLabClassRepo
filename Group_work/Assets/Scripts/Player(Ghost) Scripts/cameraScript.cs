using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour {
    //public GameObject lilCamera;
    public GameObject ghostBoi;
    public float moveSpeed;

	// Use this for initialization
	void Start () {
        moveSpeed = 0.65f;
	}
	
	// Update is called once per frame
	void Update () {
        //lilCamera.transform.position = new Vector3(ghostBoi.transform.position.x, 0, 0) * moveSpeed;

        transform.position = new Vector3(ghostBoi.transform.position.x, 0, -10) * moveSpeed;
    }
}
