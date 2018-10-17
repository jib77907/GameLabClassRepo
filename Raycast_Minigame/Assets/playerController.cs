using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour {

    public Transform ropeEnd;

    private LineRenderer laserLine;

    
    //public Vector2 direction;

    //public Vector2 point;

    public float speed; 
    public Vector3 NextPosition;

    

    // Use this for initialization
    void Start () {
        laserLine = ropeEnd.GetComponent<LineRenderer>();
        // laserLine.SetPosition(0, Input.mousePosition);
        
    }


    public float playerSpeed;

   
	// Update is called once per frame
	void Update () {

        playerSpeed = 5f;

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector2.left * playerSpeed);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector2.right * playerSpeed);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Vector2 rayOrigin = this.transform.position;
            //RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.zero);
            RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Input.mousePosition); 
            float dist = Vector2.Distance(rayOrigin, Input.mousePosition);


            laserLine.enabled = true;
            //laserLine.SetPosition(0, ropeEnd.position);
            laserLine.SetPosition(0, Input.mousePosition);

            Debug.DrawRay(rayOrigin, Input.mousePosition, Color.red);

            //if (Physics.Raycast(rayOrigin, Input.mousePosition, out hit))
            if (Physics2D.Raycast(rayOrigin, Input.mousePosition))
            {
                //Debug.Log(hit.collider.tag == "ledge");
                laserLine.SetPosition(1,hit.point);

                if (hit.collider != null)
                //if (hit.collider.tag == "ledge")
                {
                    //if (hit.collider.tag == "ledge")
                    if(Physics2D.Raycast(rayOrigin,Input.mousePosition,dist, 1<< LayerMask.NameToLayer ("ledge")))
                    {
                        Debug.Log(hit.collider.name);
                        //Disable Collider
                        hit.transform.GetComponent<BoxCollider2D>().enabled = false;
                        //Movement
                        NextPosition = hit.transform.position;
                    }

                    
                   
                }
                else
                {
                    Debug.Log("Missed");
                    
                }
            }
            else
            {
                
                laserLine.SetPosition(1, Input.mousePosition * 100f);
            
        }
        }
        else
        {
            laserLine.enabled = false;   //turns laser off when not clicking
        }

        //Moving Animation
        if(transform.position != NextPosition)
        {
            transform.position = Vector3.Lerp(transform.position, NextPosition, Time.deltaTime * speed);
        }

   }
    
}

