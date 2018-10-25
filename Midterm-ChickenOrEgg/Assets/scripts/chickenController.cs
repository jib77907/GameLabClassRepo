using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickenController : MonoBehaviour {

    public float moveSpeed;

	// Use this for initialization
	void Start () {
        moveSpeed = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * moveSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * moveSpeed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * moveSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * moveSpeed);
        }
    }
}
