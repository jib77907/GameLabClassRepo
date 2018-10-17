using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("myCoroutine");
	}


    IEnumerator myCoroutine()    //needs some kind of yield
    {
        //do sth

        yield return new WaitForSeconds(2); //pause and comeback
        
        //do sth else

        yield return null;   //go back to regular action
    }
}
