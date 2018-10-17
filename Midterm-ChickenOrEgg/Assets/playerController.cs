using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public float playerSpeed;

    public float verticalSpeed;

    private Rigidbody2D rb;
    
    //private bool moving = false;

   


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        
    }

   
	
	// Update is called once per frame
	void Update () {
        playerSpeed = 5f;
        verticalSpeed = 5f;

        float xSpeed = Input.GetAxis("Horizontal") * playerSpeed;    
        float ySpeed = rb.velocity.y; //keep velocity


        // if (gameObject.transform.position.y < 685f)
        //{
        //  gameObject.transform.Translate(Vector2.up * Time.deltaTime * verticalSpeed);
        //}



        //moving = true;

        //if (moving != false)
        ///{
        //gameObject.transform.Translate(Vector2.up * Time.deltaTime * playerSpeed);
        //}
        //  }

        rb.velocity = new Vector2(xSpeed, ySpeed);

        //if (Input.GetKeyDown(KeyCode.A) && gameObject.transform.position.x > -13f)
       // {
            //transform.Translate(Vector2.left * playerSpeed);
        //}

        //if (Input.GetKeyDown(KeyCode.D) && gameObject.transform.position.x < 13f)
      //  {
            //transform.Translate(Vector2.right * playerSpeed);
      //  }

      
    }
    //debug works but objects goes through
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            Debug.Log("HIT WALL");
            verticalSpeed = 0f;
            
        }
    }
}
