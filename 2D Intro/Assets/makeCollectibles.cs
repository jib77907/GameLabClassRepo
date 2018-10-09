using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeCollectibles : MonoBehaviour {

    //public GameObject diamond;
    float timer = 0;
    public GameObject[] diamonds;
    private List<GameObject> diamondPickUp;

    // Use this for initialization
    void Start () {
        diamondPickUp = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;

        if (timer >= 2f)
        {
            spawnDiamond();
            
            //GameObject clone = Instantiate(diamond, (new Vector2(Random.Range(-15f, 15f), Random.Range(1f,6.3f))), Quaternion.identity);
            //diamondPickUp.Add(diamondPickUp);
            

            if (timer >= 2.5f)
            {
                deleteDiamond();
               
            //}
             //if (timer >= 2.2) {
               // timer = 0;
               // deleteDiamond();
            }


        }

        //if (timer >= 3)
        //{

        //}
      


        //else
        //if (timer >= 3f)
        //{
        //     Destroy(diamond);
        // }



        //diamonds = GameObject.FindGameObjectsWithTag("collectible");    
        //foreach (GameObject diamond in diamonds)
        //{
        //diamond.transform.localPosition = new Vector2(diamond.transform.localPosition.x, diamond.transform.localPosition.y - 0.04f);


        //if (diamond.transform.localPosition.y < -6.4f)
        //{
        //Destroy(diamond);
        //}
        //}


    }

    private void deleteDiamond()
    {
        Destroy(diamondPickUp[0]);
        diamondPickUp.RemoveAt(0);
    }

    private void spawnDiamond (int diamondindex = -1)
    {
        GameObject go;

        if (diamondindex == -1)
            go = Instantiate(diamonds[0], (new Vector2(Random.Range(-15f, 15f), Random.Range(2f, 6.3f))), Quaternion.identity) as GameObject;

        else
            go = Instantiate(diamonds[diamondindex]) as GameObject;

        diamondPickUp.Add(go);
    }
}
