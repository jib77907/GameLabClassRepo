﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereShaker : MonoBehaviour {

    Animator anim;
    float dist;
    public GameObject cube;


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        dist = Vector3.Distance(cube.transform.position, transform.position);
        anim.SetFloat("doShaky", dist);
        

	}
}
