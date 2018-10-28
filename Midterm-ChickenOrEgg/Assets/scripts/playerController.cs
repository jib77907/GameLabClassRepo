using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour {

    public float playerSpeed;
    public string scene;
    public string nextScene;
    // public float verticalSpeed;
    float xSpeed;
    float ySpeed;

    private Rigidbody2D rb;
    
    //private bool moving = false;

   


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        
    }

   
	
	// Update is called once per frame
	void Update () {
        playerSpeed = 6.8f;
        //verticalSpeed = 5f;

        xSpeed = Input.GetAxis("Horizontal") * playerSpeed;    
        ySpeed = rb.velocity.y; //keep velocity


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
        if (other.gameObject.CompareTag("hill"))
        {

            //verticalSpeed = 0f;
            ySpeed = 0f;
            
        }

        if (other.gameObject.CompareTag("enemy"))
        {
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
        }

        
        
    }

   void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("endLevel")) {
            SceneManager.LoadScene(nextScene);
        }
    }
}
