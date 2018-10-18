using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour {

    public GameObject scrollThis;
    public float scrollSpeed;
    //private Vector3 startPosition;

    // Use this for initialization
    void Start () {
        //startPosition = scrollThis.transform.position;

        scrollSpeed = 1.4f;
	}
	
	// Update is called once per frame
	void Update () {
        scrollThis.transform.position = new Vector3(Mathf.Repeat(Time.time * scrollSpeed, 21f), transform.position.y, transform.position.z);

        if (scrollThis.transform.position.x >= 40)
        {
            scrollThis.transform.position = new Vector3(Mathf.Repeat(Time.time, 5), transform.position.y, transform.position.z);

        }

    }
}
