using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour {

   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ferris")
        {
            gameManager.control.ferrisCount++;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "gate")
        {
            if (other.gameObject.name == "fireGate")
            {
                SceneManager.LoadScene("fireWorld");
            }

            if (other.gameObject.name == "homeGate")
            {
                SceneManager.LoadScene("Home");
                
            }
        }

        if (other.gameObject.tag == "key")
        {
            gameManager.control.lionUnlocked = true;
            Destroy(other.gameObject);
        }
    }



   
}
