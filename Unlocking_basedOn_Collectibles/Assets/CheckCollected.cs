using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckCollected : MonoBehaviour {

    public Image lion_icon, fire_icon, ferris1, ferris2, ferris3;

	// Use this for initialization
	void Start () {
        ferris1.enabled = false;
        ferris2.enabled = false;
        ferris3.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {

        lion_icon.enabled = gameManager.control.lionUnlocked;
        fire_icon.enabled = gameManager.control.fireUnlocked;

       
       if (gameManager.control.ferrisCount >= 1)
        {
            ferris1.enabled = true;
        } else if (gameManager.control.ferrisCount >= 2)
        {
            ferris2.enabled = true;
        }else if (gameManager.control.ferrisCount >= 3)
        {
            ferris3.enabled = true;
        }
	}
}
