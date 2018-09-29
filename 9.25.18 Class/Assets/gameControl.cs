using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameControl : MonoBehaviour {

    public static gameControl control;   //public = can be called in different script

    public float health;
    public float money;

    private void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);  //dont destroy that game object if control exist
            control = this;  //this= this script
        } else if (control != this)
        {
            Destroy(gameObject);     //destroy object if control doesnt exit and use old one (in this case teh health & money)
        }
    }

    //create buttons for the variables

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "Health: " + health);
        GUI.Label(new Rect(10, 40, 100, 30), "Money: " + money);
    }

}
