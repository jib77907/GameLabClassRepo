using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteControl : MonoBehaviour {

    SpriteRenderer sr;

    public Sprite jumpLeft;
    public Sprite jumpRight;
    public Sprite standing;


    // Use this for initialization
    void Start () {
        sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("platform"))
        {
            sr.sprite = standing;

        } 
        else if (other.gameObject.CompareTag("leftWall"))
        {
            sr.sprite = jumpRight;
        }

        else if (other.gameObject.CompareTag("rightWall"))
        {
            sr.sprite = jumpLeft;
        }

       
    }

}
