using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class extraCollider : MonoBehaviour {
    public string scene;

    public Text wintext;

    public GameObject restartButton;


    // Use this for initialization
    //void Start () {
    //   wintext.text = "";
    //   restartButton.SetActive(false);
    //}
    private void Awake()
    {
        wintext.text = "";
        restartButton.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            //other.gameObject.SetActive(false);
            Debug.Log("HIT by bullet");
          SceneManager.LoadScene(scene, LoadSceneMode.Single);

        }

        if (other.gameObject.CompareTag("endMark"))
        {
            //you win
            Debug.Log("you win");
            wintext.text = "You Win!";
            restartButton.SetActive(true);
          

        } else { restartButton.SetActive(false); }
    }
}


