using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BedroomDoor : MonoBehaviour {

    public GameObject bedroomKey;

   
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
       
    }

    void OnTriggerStay2D(Collider2D other)
    {

        if (other.CompareTag("Player") && bedroomKey.GetComponent<KeyDialogTrigger>().haveKey == true)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                SceneManager.LoadScene("LivingRoom");
            }
        }

    }
}
