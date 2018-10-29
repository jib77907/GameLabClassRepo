using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class comicMovement02 : MonoBehaviour {

    public float readSpeed;

    public string scene;

    public GameObject restartButton;



    // Use this for initialization
    void Start () {
        readSpeed = 0.014f;

        restartButton.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.up * readSpeed);

        if (transform.position.y >= 25.79)
        {
            readSpeed = 0f;

            restartButton.SetActive(true);
        }
    }
}
