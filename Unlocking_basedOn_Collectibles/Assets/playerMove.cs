using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

    float moveForce;
    Rigidbody2D rb;
    
    // Use this for initialization
    void Start()
    {
        moveForce = 1.2f;
        rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(0.2f, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-0.2f, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up * moveForce, ForceMode2D.Impulse);
        }
        resetPos();
    }

    void resetPos()
    {
        if (transform.position.x <= -8)
        {
            transform.position = new Vector3(7.8f, transform.position.y, transform.position.z);
        }
        if (transform.position.x >= 8)
        {
            transform.position = new Vector3(-7.8f, transform.position.y, transform.position.z);
        }
        if (transform.position.y <= -5.3f)
        {
            transform.position = new Vector3(transform.position.x, 5.2f, transform.position.z);
        }
        if (transform.position.y >= 5.3f)
        {
            transform.position = new Vector3(transform.position.x, -5.2f, transform.position.z);
        }
    }
}
