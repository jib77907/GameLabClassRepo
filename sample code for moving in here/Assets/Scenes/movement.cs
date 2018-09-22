using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float speed;
    public float moveSpeed;
    public float turnSpeed;

	// Use this for initialization
	void Start () {
        moveSpeed = 20f;
        turnSpeed = 100f;
	}
	
	// Update is called once per frame
	void Update () {
        //these 2 are doing the same thing (forward = 0,0,1)
        //transform.Translate (new Vector3(0, 0, 1) * Time.deltaTime * speed);
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //transform.Rotate(Vector3.up, speed * Time.deltaTime);

        //if (Input.GetKey(KeyCode.W)) {
        //transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        //}
        // if (Input.GetKey(KeyCode.A))
        //{
        //transform.Translate(Vector3.left * Time.deltaTime * speed);
        // transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        // }
        //if (Input.GetKey(KeyCode.D))
        //{
        //transform.Translate(Vector3.right * Time.deltaTime * speed);
        //transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        //}
        // if (Input.GetKey(KeyCode.UpArrow))
        //{
        //transform.Translate(Vector3.up * Time.deltaTime * speed);
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //transform.Translate(Vector3.down * Time.deltaTime * speed);
        //}
        // this sets the position equal to a new value instead of adding Vector3
        //transform.position = transform.position.x, transform.position.y, transform.position.z;
        //ping pong changes the value between 0 and the value you set, in this we use 3
        //transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 3), transform.position.y, transform.position.z);

        //use lerping to move between a start and end position
        Vector3 start = new Vector3(1f, 3f, 5f);
        Vector3 end = new Vector3(8f, -2f, 4f);

        //3rd value is how far it would move between start and end (start, end, howfar)
        Vector3 moving = Vector3.Lerp(start, end, Mathf.PingPong(Time.time, 1));
        transform.position = moving;
    }
}
