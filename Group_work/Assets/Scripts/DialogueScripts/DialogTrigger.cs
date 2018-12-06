using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour {

    public Dialogue dialogue;

    public bool havePicture, havePhone, haveGift, haveNote, haveGlass;

    public bool foundGPS;

    public GameObject car;

    public BoxCollider2D carDoor;

    void Start()
    {
        havePicture = false;
        havePhone = false;
        haveGift = false;
        haveNote = false;
        haveGlass = false;

        foundGPS = false;
        carDoor = car.GetComponent<BoxCollider2D>();
        carDoor.enabled = false;
    }

    public void TriggerDialogue(){
       
            FindObjectOfType<DialogManager>().StartDialoque(dialogue);
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
       

        if (other.CompareTag("Player"))
        {

           
                if (Input.GetKeyDown(KeyCode.I))
                {
                   
                    TriggerDialogue();


                if (this.gameObject.CompareTag("Picture"))


                {

                    havePicture = true;

                }

                if (this.gameObject.CompareTag("Phone"))


                {

                    havePhone = true;

                }
                if (this.gameObject.CompareTag("Gift"))


                {

                    haveGift = true;

                }
                if (this.gameObject.CompareTag("Note"))


                {

                    haveNote = true;

                }
                if (this.gameObject.CompareTag("Glass"))


                {

                    haveGlass = true;

                }
                if (this.gameObject.CompareTag("GPS"))


                {

                    foundGPS = true;

                    if (foundGPS)
                    {
                        carDoor.enabled = true;
                    }

                }


            }

        }

    }
}
