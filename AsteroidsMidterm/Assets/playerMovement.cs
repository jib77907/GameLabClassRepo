using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{ public GameObject player;
    public float turnSpeed;
    public float moveSpeed;
    // Use this for initialization
    void Start()
    {
        turnSpeed = 150f;
        moveSpeed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("asteroid"))
        {
            Destroy(player);
            //SceneManager.LoadScene(scene, LoadSceneMode.Single);

        }
    }
}
