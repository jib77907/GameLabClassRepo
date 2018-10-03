using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishMovementLvl2 : MonoBehaviour {
    public static float count;
    public float speed;
    public float moveSpeed;
    public float upforce;
    public float turnSpeed;
    //private float count;
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
        countText.text = "Count: " + ScoreSystem.control.count; //count.ToString();
        eatenText.text = "";
        finishText.text = "";

        gameEndingMark = false;

        restartButton.SetActive(false);
    }

    public void RestartGame()
    {

    }
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
            //count = count + 1;
            ScoreSystem.control.count += 1;
            SetCountText();
        }

        if (other.gameObject.CompareTag("Pick up big"))
        {
            other.gameObject.SetActive(false);
            //count = count + 5;
            ScoreSystem.control.count += 5;
            SetCountText();
        }

        if (other.gameObject.CompareTag("Jelly"))
        {
            other.gameObject.SetActive(false);
            //count = count - 3;
            ScoreSystem.control.count -= 3;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Wall end"))
        {
            finishText.text = "You got " + count.ToString();
            gameEndingMark = true;
            restartButton.SetActive(true);
        }

    }
    void SetCountText()
    {
        countText.text = "Count:" + count.ToString();
        //if (count >= 50)
        //{
            //eatenText.text = "All Fish Eaten!";
        //}
    }

    //void SetFinishText()
    //{
    //if (other.gameObject.CompareTag("Wall end"))
    // {
    //finishText.text = "You got " + countText.text + " points";

    //}
    //}
}

