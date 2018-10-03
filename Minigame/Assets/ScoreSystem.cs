using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour {

    public static ScoreSystem control;

    public float count;

    private void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);  //dont destroy that game object if control exist
            control = this;  //this= this script
        }
        else if (control != this)
        {
            Destroy(gameObject);     //destroy object if control doesnt exit and use old one (in this case teh health & money)
        }
    }
}
