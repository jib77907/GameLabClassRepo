using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cirleCollect : MonoBehaviour {

    public GameObject circle;
    public string scene;

    public float count;
   
    public Text countText;

    // Use this for initialization
    void Start () {
        countText.text = "Count: " + count.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		if (circle.transform.position.y < -10)
        {
            SceneManager.LoadScene(scene);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("collectible"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count:" + count.ToString();

    }
}
