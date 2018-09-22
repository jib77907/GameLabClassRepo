using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollingthe_ball : MonoBehaviour {
    public float force;
    public float upforce;
    //public float downforce;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //, ForceMode.Impulse

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * force);

        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * force);
        }

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
            //GetComponent<Rigidbody>().AddTorque(Vector3.up * upforce);
        }

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * force);
            //GetComponent<Rigidbody>().AddForce(Vector3.back * downforce, ForceMode.Impulse);
        }

        if(Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * upforce);
        }
    }

    //bool
}
