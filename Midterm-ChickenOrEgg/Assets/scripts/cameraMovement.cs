using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour {
    public float playerSpeed;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        playerSpeed = 4.97f;

        if (gameObject.transform.position.y < 690f)
        {
            gameObject.transform.Translate(Vector2.up * Time.deltaTime * playerSpeed);
        }
    }
}
