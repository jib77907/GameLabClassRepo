using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShot : MonoBehaviour {

    public float shotSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * shotSpeed);

        if (transform.position.x < -14 || transform.position.x > 14 || transform.position.z < -20.4 || transform.position.z > 1.4) {
            Destroy(this.gameObject);
        }
	}
}
