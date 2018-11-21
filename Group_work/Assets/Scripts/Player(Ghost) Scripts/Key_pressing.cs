﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_pressing : MonoBehaviour {

    SpriteRenderer rend;

    bool isShowing;
    bool inHidingZone;

    public GameObject enemy;

    // Use this for initialization
    void Start () {
        //rend = this.gameObject.transform.GetChild(0).gameObject;
        rend = GetComponent<SpriteRenderer>();

        isShowing = true;
    }
	
	// Update is called once per frame
	void Update () {
        

        //if (!isShowing){
        if(Input.GetKeyDown(KeyCode.Q)){
            if (inHidingZone){
                isShowing = false;
                Debug.Log("hide");
                //enemy.GetComponent<enemyScript>().playerShowing = isShowing;
            } else {
                isShowing = true;
                Debug.Log("show");
            }

            //isShowing = true;
            enemy.GetComponent<enemyScript>().playerShowing = isShowing;
            rend.enabled = isShowing;
          }
        //}
   
    }

    //void OnCollisionEnter2D(Collision2D collision)

    void OnTriggerStay2D(Collider2D other) {


        if (other.CompareTag("hidingSpot"))
        {
            Debug.Log("in hiding zone");
            inHidingZone = true;
            //if (Input.GetKeyDown(KeyCode.Q))
            //{
            //    //hide
            //    Debug.Log("hiding");

            //    isShowing = false;
            //    //rend.SetActive(isShowing);
            //    rend.enabled = false;
            //    //gameObject.SetActive(false);

            //    //rend.enabled = !rend.enabled;

            //}
        }


        if (other.CompareTag("item"))
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                //inspect
                //textbox will come up
                Debug.Log("inspect");
            }
        }
       
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("hidingSpot"))
        {
            inHidingZone = false;
        }
    }
}