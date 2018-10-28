using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextSceneafterTalking : MonoBehaviour {

    public GameObject nextSceneButton;

    public bool buttonIsThere = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (GetComponent<talkingScript>().nextText >= GetComponent<talkingScript>().textString.Count && buttonIsThere == false) {
            Instantiate(nextSceneButton);
            buttonIsThere = true;
        }
	}

    void OnTriggerExit2D(Collider2D player)
    {
        if (player.CompareTag("Player")) {
            //Instantiate(nextSceneButton);


        }
    }
}
