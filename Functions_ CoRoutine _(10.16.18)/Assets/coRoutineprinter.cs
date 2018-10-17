using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coRoutineprinter : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("Wait2Seconds");
        Debug.Log("HELLO!!!");    
	}
	
	IEnumerator Wait2Seconds()                      // other stuff can go on during yield
    {
        Debug.Log("1");
        yield return new WaitForSeconds(2);
        Debug.Log("2");
        yield return new WaitForSeconds(2);
        Debug.Log("3");
    }
}
