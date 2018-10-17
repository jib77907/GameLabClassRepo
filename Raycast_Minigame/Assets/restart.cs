using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restart : MonoBehaviour {

    // public void StartGame(string levelName)
    // {
    //   SceneManager.LoadScene(levelName);
    //}

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


      
    }
}
