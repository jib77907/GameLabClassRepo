using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidMaker : MonoBehaviour {

    public GameObject asteroid;

    GameObject[] asteroids;

    float timer = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer >= 2f)
        {
            GameObject clone = Instantiate(asteroid, new Vector3(Random.Range(-10f, 12f), 4.8f, -16.7f), Quaternion.identity);
            GameObject clone2 = Instantiate(asteroid, new Vector3(Random.Range(-10f, 12f), 4.8f, -4.3f), Quaternion.identity);
            GameObject clone3 = Instantiate(asteroid, new Vector3(-10f, 4.8f, Random.Range(-16.7f, -4.3f)), Quaternion.identity);
            GameObject clone4 = Instantiate(asteroid, new Vector3(12f, 4.8f, Random.Range(-16.7f, -4.3f)), Quaternion.identity);

            timer = 0;
        }

        asteroids = GameObject.FindGameObjectsWithTag("asteroid");       
        foreach (GameObject asteroid in asteroids)
        {
            //asteroid.transform.localPosition =  Vector3.forward; //(asteroid.transform.localPosition.x - 0.5f, asteroid.transform.localPosition.y);
            asteroid.transform.Translate( new Vector3(10,0,10) * Time.deltaTime/5);

            



            if (asteroid.transform.localPosition.x < -17)
             {
             Destroy(asteroid);
             }

            if (asteroid.transform.localPosition.z < -17)
            {
                Destroy(asteroid);
            }
        }
    }
}
