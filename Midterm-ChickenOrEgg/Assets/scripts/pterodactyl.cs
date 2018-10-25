using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pterodactyl : MonoBehaviour {
   
  
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        

        Vector3 start = new Vector3(50f, transform.position.y, 5f);
       Vector3 end = new Vector3(-50f, transform.position.y - 0.2f, 4f);

       Vector3 moving = Vector3.Lerp(start, end, Mathf.PingPong(Time.time, 1));
       transform.position = moving;

       
        
    }
}
