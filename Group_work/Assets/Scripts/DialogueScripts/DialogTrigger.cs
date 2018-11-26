using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour {

    public Dialogue dialogue;

    public GameObject obtainKey;

    public bool haveKey;

    void Start()
    {
        haveKey = false;
    }

    public void TriggerDialogue(){
       
            FindObjectOfType<DialogManager>().StartDialoque(dialogue);
        
    }

    void OnTriggerStay2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                //inspect
                //textbox will come up
                Debug.Log("inspect");
                TriggerDialogue();

                Destroy(obtainKey);
                haveKey = true;
            }
        }

    }
}
