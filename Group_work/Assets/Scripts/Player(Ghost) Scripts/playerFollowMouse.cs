using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFollowMouse : MonoBehaviour { 

    private Vector3 mousePos;
    public float moveSpeed;
    public GameObject ghost;

	// Use this for initialization
	void Start () {
        moveSpeed = 0.05f;
	}
	
	// Update is called once per frame
	void Update () {
        //Example code
        //transform.position = Vector2.Lerp(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), moveSpeed);

        //Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
       // diff.Normalize();

       // float rotation_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
       // transform.rotation = Quaternion.Euler(0f, 0f, rotation_z);

        //our code for following mouse
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       transform.position = Vector2.Lerp(transform.position, mousePos, moveSpeed);

        //flipping sprite
        Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        float worldXPos = Camera.main.ScreenToWorldPoint(pos).x;

        if (worldXPos > ghost.transform.position.x) 
        {
            // Facing right
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            // Facing left
            transform.localScale = new Vector3(1, 1, 1);
        }

    }
}
