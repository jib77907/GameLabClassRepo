using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemyScript : MonoBehaviour {

    public float speed;

    public Transform target;
    public float chaseRange;

    public bool playerShowing;

    
	// Use this for initialization
	void Start () {
        playerShowing = true;
        speed = 3f;
        
	}

    // Update is called once per frame
    void Update()
    {

        if (playerShowing)
        {
            //chasing player
            float distanceToTarget = Vector3.Distance(transform.position, target.position);
            

            if (distanceToTarget < chaseRange)
            {
               
                //new chase
                Vector3 localPosition = target.position - transform.position;
                localPosition = localPosition.normalized;
                transform.Translate(localPosition.x * Time.deltaTime * speed, 0, localPosition.z * Time.deltaTime * speed);
               

                //flip
                Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
                float worldXPos = Camera.main.ScreenToWorldPoint(pos).x;

                if (worldXPos > gameObject.transform.position.x)
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
        } else {
           
            //not follow
            //either walk around w/ code or animation
          
           
        }

        
    }
}
