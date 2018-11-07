using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAsteroid : MonoBehaviour {

    float posX, posZ;
    public float speed;
    public float hp;
   

	// Use this for initialization
	void Start () {
        posX = Random.Range(-14, 14);
        posZ = Random.Range(-20.4f, 1.4f);

        transform.position = new Vector3(posX, 0, posZ);

        Vector3 euler = transform.eulerAngles;
        euler.y = Random.Range(0f, 360f);
        transform.eulerAngles = euler;  //euler angles uses degree

        hp = Random.Range(1, 3);
        transform.localScale = new Vector3(hp * 2, hp * 2, hp * 2);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        speed = 5 - hp;
        
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
