using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

    public static gameManager control;  //public static has to have the same name as the script

    public bool lionUnlocked, fireUnlocked;
    public int ferrisCount;

    void Awake()
    {
        // 3 - if there's no gamecontrol, make this the game control
        //keep track of information from scene to scene
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;   // this means this script
        }
        else if (control != this)
        {
            Destroy(gameObject);  // there can be only one
        }
    }

    void Start()
    {
        lionUnlocked = false;
        fireUnlocked = true;
        ferrisCount = 0;
    }

}
