using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShip : MonoBehaviour {

    Rigidbody rb;
    public float moveForce;
    public float turnForce;
    

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.forward, ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(Vector3.up * -turnForce, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(Vector3.up * turnForce, ForceMode.Impulse);
        }

        ScreenWrap();
    }

    void ScreenWrap()
    {
        if (transform.position.x < -14)
        {
            transform.position = new Vector3(13, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 14)
        {
            transform.position = new Vector3(-13, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -20.4f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 19.4f);
        }
        if (transform.position.z > 1.4f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -20.4f);
        }
    }
}
