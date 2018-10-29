using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class comicMovement01 : MonoBehaviour {

    public float readSpeed;

    public string scene;

	// Use this for initialization
	void Start () {
        readSpeed = 0.014f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.up * readSpeed);

        if (transform.position.y >= 34) {
            SceneManager.LoadScene(scene);
        }
	}
}
