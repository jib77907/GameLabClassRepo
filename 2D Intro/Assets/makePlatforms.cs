using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makePlatforms : MonoBehaviour {

    public GameObject platform;
    //GameObject clone;
    float timer = 0;

    GameObject[] platforms; //array is a collection of objects

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;  //timer counting up every time

        if (timer >= 0.8f)   //if timer greater than 0.5, make a new platform
        {

          GameObject clone = Instantiate(platform, (new Vector2(Random.Range(-8f, 8f), 6f)), Quaternion.identity);   //(what, where, rotation)
        //change size ??!!
            clone.transform.localScale = new Vector2 (Random.Range(2f,8f), 1f);
            timer = 0;

        }

        platforms = GameObject.FindGameObjectsWithTag("platform");       //search for all tagged with "platform", move it, and destroy it if it goes out of range
        foreach(GameObject platform in platforms)
        {
            platform.transform.localPosition = new Vector2(platform.transform.localPosition.x, platform.transform.localPosition.y - 0.07f);

            if (platform.transform.localPosition.y < -6)
            {
                Destroy(platform);
            }
        }

	}
}
