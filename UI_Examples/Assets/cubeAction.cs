using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //UI system included

public class cubeAction : MonoBehaviour {

    public Slider slidey;
    public Text winText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        //change UI
        float value = slidey.value;
        slidey.value = slidey.value + 1;

        //change wintext
        if (slidey.value <= 1)
        {
            winText.text = "";
        } else if (slidey.value == 5)
        {
            winText.text = "YOU WIN!";
        }

        Destroy(this.gameObject);
    }


}
