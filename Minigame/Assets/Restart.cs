using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour {
    /// <summary>
    public Button restartButton;
    public string scene;

    private void OnEnable()
    {
        restartButton.onClick.AddListener(RestartGame);
    }
    /// </summary>
    public void RestartGame()
    {
        SceneManager.LoadScene(scene);
        //UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // Use this for initialization

      
		
	}
	

}
