using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;

        Debug.DrawRay(transform.position, Vector3.forward * 5, Color.green);

        if (Physics.Raycast(transform.position, Vector3.down, out hit))  //where it is, where its looking, out hit, how long
        {
            
            if (hit.collider.tag == "ledge")
            {
                //do sth
                GetComponent<MeshRenderer>().material.color = Color.cyan;         //get mesh renderer and change the material color
            }
        }

    }
}

