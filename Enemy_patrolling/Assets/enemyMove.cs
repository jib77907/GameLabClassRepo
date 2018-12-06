using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour {

    public float speed;
    public Transform[] moveSpots;
    int targetSpot;

    float distToSpot;

    float waitTime;
    float startWait;

    public GameObject player;

    float chaseDist;
    float chaseSpeed;

	// Use this for initialization
	void Start () {
        targetSpot = 0;
        distToSpot = 0.02f;
        startWait = 1f;
        waitTime = startWait;
        chaseDist = 3f;
        chaseSpeed = 2f;
	}
	
	// Update is called once per frame
	void Update () {

        if (Vector2.Distance(transform.position, player.transform.position) < chaseDist)
        {
            //CHASE
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, chaseSpeed * Time.deltaTime);
            chaseSpeed += 0.01f;  //accelerate
        }
        else
        {
            //PATROL
            chaseSpeed = 2f;
             transform.position = Vector2.MoveTowards(transform.position, moveSpots[targetSpot].position, speed * Time.deltaTime);  //(from, to, speed)

        if(Vector2.Distance(transform.position, moveSpots[targetSpot].position) < distToSpot)
        {
            if(waitTime <= 0)
            {
                //targetSpot = Random.Range(0, moveSpots.Length);
                targetSpot++;

                if (targetSpot > moveSpots.Length - 1)
                {
                    targetSpot = 0;
                }
                waitTime = startWait;
            } else
            {
                waitTime -= Time.deltaTime;
            }

           
        }
        }



       
	}
}
