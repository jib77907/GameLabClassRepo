using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oldercroc2 : MonoBehaviour {

    public float divideSpeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 start = new Vector3(5.5f, transform.position.y, 0f);
        Vector3 end = new Vector3(-50f, transform.position.y, 0f);

        //3rd value is how far it would move between start and end (start, end, howfar)
        Vector3 moving = Vector3.Lerp(start, end, Mathf.PingPong(Time.time/ divideSpeed, 1));
        transform.position = moving;
    }
}
