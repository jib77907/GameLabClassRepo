using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickenController : MonoBehaviour {

    Animator chicken;

    SpriteRenderer sr;

    public Sprite lookRight;
    public Sprite lookLeft;
    public Sprite lookBack;
    //public Sprite lookCenter;


    public float moveSpeed;

	// Use this for initialization
	void Start () {

        chicken = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();

        moveSpeed = 0.03f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A))
        {
            //sr.sprite = lookLeft;

            chicken.SetBool("lookingleft", true);

            chicken.SetBool("lookingright", false);

            chicken.SetBool("lookingfront", false);

            chicken.SetBool("lookingup", false);


            transform.Translate(Vector2.left * moveSpeed);
        }

         else if (Input.GetKey(KeyCode.D))
        {
            // sr.sprite = lookRight;

            chicken.SetBool("lookingright", true);

            chicken.SetBool("lookingleft", false);

            chicken.SetBool("lookingfront", false);

            chicken.SetBool("lookingup", false);

            transform.Translate(Vector2.right * moveSpeed);
        }

        else if (Input.GetKey(KeyCode.W))
        {
            //sr.sprite = lookBack;

            chicken.SetBool("lookingup", true);

            chicken.SetBool("lookingleft", false);

            chicken.SetBool("lookingfront", false);

            chicken.SetBool("lookingright", false);

            transform.Translate(Vector2.up * moveSpeed);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            chicken.SetBool("lookingfront", true);

            chicken.SetBool("lookingup", false);

            chicken.SetBool("lookingleft", false);

            chicken.SetBool("lookingright", false);

            transform.Translate(Vector2.down * moveSpeed);
        }
    }


}
