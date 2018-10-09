using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeRays : MonoBehaviour {

    public float height = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        RaycastHit hit;

        Debug.DrawRay(transform.position, Vector3.down * 5, Color.green);

        if (Physics.Raycast (transform.position, Vector3.down, out hit, height))  //where it is, where its looking, out hit, how long
        {
            //Debug.Log("5 or less unit from  ground");
            //Debug.Log(hit.collider.tag);
            if (hit.collider.tag == "ground")
            {
                //do sth
                GetComponent<MeshRenderer>().material.color = Color.cyan;         //get mesh renderer and change the material color
            }
        }

	}
}
