using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeAsteroids : MonoBehaviour {

    public GameObject asteroid;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 8; i++)
        {
            Instantiate(asteroid, new Vector3(10, 0, 0), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
