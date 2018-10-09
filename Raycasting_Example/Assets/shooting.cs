﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {

    public Transform gunEnd;
    private Camera fpsCam;
    private LineRenderer laserLine;

	// Use this for initialization
	void Start () {
        fpsCam = GetComponentInChildren<Camera>();
        laserLine = gunEnd.GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetButton("Fire1"))   //left mouse button
        {
            Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(.5f, .5f, 0f));
            RaycastHit hit;

            laserLine.enabled = true;
            laserLine.SetPosition(0, gunEnd.position);
            //Debug.DrawRay(rayOrigin, fpsCam.transform.forward);

            if (Physics.Raycast (rayOrigin, fpsCam.transform.forward, out hit)) {  // dont say anyhting if infinite
                //do sth if hit cubes
                Debug.Log(hit.collider.tag);
                laserLine.SetPosition(1, hit.point);             //draw a line from gun to a point where it hits sth

                if (hit.collider.tag == "cube")
                {
                    hit.collider.GetComponent<MeshRenderer>().material.color = Color.yellow;
                }
            } else
            {
                laserLine.SetPosition(1, fpsCam.transform.forward * 100f);
            }
        } else
        {
            laserLine.enabled = false;   //turns laser off when not clicking
        }

	}
}
