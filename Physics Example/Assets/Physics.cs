using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{
    
    // Use this for initialization
    void Start()
    {

    }
    void FixedUpdate()
    {
        //if (Input.GetKey(KeyCode.A))
        //{
            //do sth

        //}
    }

    void OnCollisionEnter(Collision other)
    {
        //same as println
        //Debug.Log("i'm touching sth");
        Debug.Log(other.gameObject.tag);
        //specifying what concole says
        if (other.gameObject.tag == "sphere")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    void OnCollisionStay(Collision other)
    {
        // Debug.Log("still touching");
        //GetComponent<Rigidbody>().AddForce(Vector3.up * upforce);
        if (other.gameObject.tag == "sphere")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    void OnCollisionExit(Collision other)
    {
        //Debug.Log("no longer touching");
        if (other.gameObject.tag == "sphere")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    public float upforce;

    //if mouse click on object
    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * upforce);
        GetComponent<Rigidbody>().AddTorque(Vector3.up * upforce);
        //torque = spinning (vector3.axis(up) * upforce)
    }


    void OnTriggerEnter(Collider other)
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * upforce);
        GetComponent<Rigidbody>().AddTorque(Vector3.up * upforce);
    }

    void OnTriggerExit(Collider other)
    {

    }









}