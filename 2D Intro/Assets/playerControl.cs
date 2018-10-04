using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerControl : MonoBehaviour
{

    //public float count;
    //public Text countText;

    // Use this for initialization
    void Start()
    {
        //countText.text = "Count: " + count.ToString();
    }


    //public float val;
    public float speed;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //GetComponent<Rigidbody2D>().AddForce(Vector3.right * val, ForceMode2D.Impulse);
            transform.Translate(Vector2.right * speed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //GetComponent<Rigidbody2D>().AddForce(Vector3.left * val, ForceMode2D.Impulse);
            transform.Translate(Vector2.left * speed);
        }



    }


    //void OnTriggerEnter2D (Collider2D other)
    //{
      //  if (other.gameObject.CompareTag("collectible"))
        //{
          //  other.gameObject.SetActive(false);
            //count = count + 1;
            //SetCountText();
        //}
    //}

    //void SetCountText()
    //{
      //  countText.text = "Count:" + count.ToString();
       
    //}
}
