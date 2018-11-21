﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalMovemenr : MonoBehaviour {

    public GameObject cubePortal, spherePortal;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(Vector3.forward * 5 * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.forward * -5 * Time.deltaTime);

        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (other.gameObject.name == "CubePortal") {
            transform.position = spherePortal.transform.position + new Vector3(-4,0,0);

        }

        if (other.gameObject.name == "SpherePortal") {
            transform.position = cubePortal.transform.position + new Vector3(4,0,0);
        }
    }
}