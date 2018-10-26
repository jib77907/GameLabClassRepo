using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bulletHit : MonoBehaviour
{

    public float score;
    public Text scoreText;



    // Use this for initialization
    void Start()
    {
        score = 0;
        scoreText.text = "Score:" + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("asteroid"))
        {
            other.gameObject.SetActive(false);
            score = score +1;

            SetScoreText();

          

        }
    }


    void SetScoreText()
    {
        scoreText.text = "Score:" + score.ToString();
    }
}