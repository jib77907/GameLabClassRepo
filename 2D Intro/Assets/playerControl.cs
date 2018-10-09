using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerControl : MonoBehaviour
{


    public float turnSpeed;
    public Quaternion zOrigin;
    
   // public Transform from;
    //public Transform to;
    public float speed = 0.1F;

    // Use this for initialization
    void Start()
    {
       turnSpeed = 1.5f;
        zOrigin = this.transform.rotation;
       
    }


    //public float val;
    public float playerSpeed;
    
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow) && this.transform.position.x < 15f)
        {
            //GetComponent<Rigidbody2D>().AddForce(Vector3.right * val, ForceMode2D.Impulse);
            transform.Translate(Vector2.right * playerSpeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && this.transform.position.x > -15f)
        {
            //GetComponent<Rigidbody2D>().AddForce(Vector3.left * val, ForceMode2D.Impulse);
            transform.Translate(Vector2.left * playerSpeed);
        }

        if (Input.GetKey(KeyCode.UpArrow) && this.transform.position.x < 14.1f && this.transform.position.x > -14.1f && this.transform.position.y < 7f && this.transform.position.y > -7f) 
        {
            transform.Rotate(0, 0, turnSpeed);

           
            //Lerp??
            //transform.rotation = Quaternion.Lerp(from.rotation, to.rotation, Time.time * speed);

        }
        //else if (this.transform.rotation.z != 0)
        //{
           // transform.rotation = zOrigin;
        //}

       else if (Input.GetKey(KeyCode.DownArrow)) //&& this.transform.position.x < 14.1f && this.transform.position.x > -14.1f && this.transform.position.y < 7f && this.transform.position.y > -7f)
            {
            transform.Rotate(0, 0, -turnSpeed);


        }
        else 
        {
            //this.transform.rotation.z != 0;
            transform.rotation = zOrigin ;
        }

     
    }

    
}

