using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

    public GameObject sphere;
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine("Fade");
        }

        StartCoroutine("SphereCheck");
    }

    IEnumerator SphereCheck()
    {
        //check for distance
        float dist = Vector3.Distance(transform.position, sphere.transform.position);
        if (dist < 5f)
        {
            Debug.Log("oh noooo");

        }else
        {
            Debug.Log("safe");
        }

        yield return new WaitForSeconds(0.1f);
    }


    IEnumerator  Fade() {
        for (float i = 1; i >= 0; i-= 0.01f)
        {
            Color c = GetComponent<Renderer>().material.color;
            c.a = i;        //a is alpha
            GetComponent<Renderer>().material.color = c;
            yield return null;
        }

    }
}
