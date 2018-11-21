using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showLevelObjects : MonoBehaviour {

    public GameObject lionGate;
    public GameObject ferris1, ferris2, ferris3;

	// Use this for initialization
	void Start () {
        lionGate.SetActive(gameManager.control.lionUnlocked);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
