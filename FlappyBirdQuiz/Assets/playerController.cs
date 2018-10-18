using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playerController : MonoBehaviour
{
    public string scene;

    Rigidbody2D rb2d;
    public float moveSpeed;

  

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        moveSpeed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rb2d.AddForce(transform.up * moveSpeed, ForceMode2D.Impulse);
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("UPcolumn"))
        {
            Debug.Log("DIE");
            SceneManager.LoadScene(scene, LoadSceneMode.Single);

        }
        if (other.gameObject.CompareTag("DOWNcolumn"))
        {
            Debug.Log("DIEEEE");
            SceneManager.LoadScene(scene, LoadSceneMode.Single);

        }

        if (other.gameObject.CompareTag("ground"))
        {
            Debug.Log("aww ;-;");
            SceneManager.LoadScene(scene, LoadSceneMode.Single);

        }
    }
}
