using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishMovement : MonoBehaviour
{

    public float speed;
    public float moveSpeed;
    public float upforce;
    public float turnSpeed;
    private int count;
    public Text countText;
    public Text eatenText;
    public Text finishText;
    public bool gameEndingMark;
    public GameObject restartButton;
    


    // Use this for initialization
    void Start()
    {
        speed = 17.3f;
        moveSpeed = 4f;
        turnSpeed = 142f;
        count = 0;
        countText.text = "Count:" + count.ToString() + "/50";
        eatenText.text = "";
        finishText.text = "";

        gameEndingMark = false;

        restartButton.SetActive(false);
    }

   public void RestartGame()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
       // if (Input.GetKey(KeyCode.UpArrow))
        //{
          // transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

        //}

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
          
            //transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }

        //if (Input.GetKey(KeyCode.DownArrow))
        //{
            //transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        //}

       //if (Input.GetKey(KeyCode.Space)) //originally UpArrow
        //{
            //GetComponent<Rigidbody>().AddForce(Vector3.up * upforce, ForceMode.Impulse);
            //, ForceMode.Impulse
        //}
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick up small"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
           
            SetCountText();
        }

        if (other.gameObject.CompareTag("Pick up big"))
        {
            other.gameObject.SetActive(false);
            count = count + 5;
            SetCountText();
        }

        if (other.gameObject.CompareTag("Jelly"))
        {
            other.gameObject.SetActive(false);
            count = count - 3;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Wall end"))
        {
            finishText.text = "You got " + count.ToString() + " out of 50!";
            gameEndingMark = true;
            restartButton.SetActive(true);
        }

    }
    void SetCountText ()
    {
        countText.text = "Count:" + count.ToString() + "/50";
        if (count >=50)
        {
            eatenText.text = "All Fish Eaten!";
        }
    }

    //void SetFinishText()
    //{
        //if (other.gameObject.CompareTag("Wall end"))
       // {
            //finishText.text = "You got " + countText.text + " points";

        //}
    //}
}




//public float speed;
//public float moveSpeed;
//public float turnSpeed;

// Use this for initialization
//void Start()
//{
//   moveSpeed = 20f;
// turnSpeed = 100f;
//}

// Update is called once per frame
//void Update()
//{
//these 2 are doing the same thing (forward = 0,0,1)
//transform.Translate (new Vector3(0, 0, 1) * Time.deltaTime * speed);
//transform.Translate(Vector3.forward * Time.deltaTime * speed);

//transform.Rotate(Vector3.up, speed * Time.deltaTime);

//if (Input.GetKey(KeyCode.W)) {
//transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
//}
//if (Input.GetKey(KeyCode.S))
//{
//transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
//}
// if (Input.GetKey(KeyCode.A))
//{
//transform.Translate(Vector3.left * Time.deltaTime * speed);
// transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
// }
//if (Input.GetKey(KeyCode.D))
//{
//transform.Translate(Vector3.right * Time.deltaTime * speed);
//transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
//}
// if (Input.GetKey(KeyCode.UpArrow))
//{
//transform.Translate(Vector3.up * Time.deltaTime * speed);
//}
//if (Input.GetKey(KeyCode.DownArrow))
//{
//transform.Translate(Vector3.down * Time.deltaTime * speed);
//}
// this sets the position equal to a new value instead of adding Vector3
//transform.position = transform.position.x, transform.position.y, transform.position.z;
//ping pong changes the value between 0 and the value you set, in this we use 3
//transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 3), transform.position.y, transform.position.z);