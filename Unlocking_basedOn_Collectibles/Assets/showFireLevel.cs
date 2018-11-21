using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showFireLevel : MonoBehaviour {

    public GameObject key;

	// Use this for initialization
	void Start () {
       
       if (gameManager.control.ferrisCount >= 3)
        {
            key.SetActive(false);
        }
	}
	
	
}
