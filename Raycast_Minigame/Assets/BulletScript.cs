using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public GameObject bullet;
   
    float timer = 0;

    GameObject[] bullets; //array is a collection of objects

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;  //timer counting up every time

        if (timer >= 0.08f)   //if timer greater than 1, make a new platform
        {

            GameObject clone = Instantiate(bullet, (new Vector2(500f,Random.Range(-21f, 662f))), Quaternion.identity);   //(what, where, rotation)


            //change size ??!!
           
            timer = 0;

        }

        bullets = GameObject.FindGameObjectsWithTag("bullet");       //search for all tagged with "platform", move it, and destroy it if it goes out of range
        foreach (GameObject bullet in bullets)
        {
            bullet.transform.localPosition = new Vector2(bullet.transform.localPosition.x -1f, bullet.transform.localPosition.y);


            if (bullet.transform.localPosition.x < -12)
            {
                Destroy(bullet);
            }
        }

    }
}
