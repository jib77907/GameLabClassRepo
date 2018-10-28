using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class talkingScript : MonoBehaviour {

    public Text speak;

    //public string customText;

    public List<string> textString;

    public int nextText;

	// Use this for initialization
	void Start () {
        nextText = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D player) {

        if (player.CompareTag("Player"))
        {

            displayText();

            //speak.text = customText;

        }

    }

    void OnTriggerExit2D()
    {
        speak.text = " ";
    }

    void displayText() {
        //Invoke("displayText", 5f);


        if (nextText <= textString.Count - 1)

        
        {
            speak.text = textString[nextText];
            Invoke("displayText", 5f);   //string has to be a name of the function
        }

        nextText = nextText + 1;

    }
}
