using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletsMaker : MonoBehaviour
{

    public GameObject bullet;

    public GameObject shooter;

    GameObject[] bullets;

    // Use this for initialization
    void Start()
    {

    }

   


    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(this.shooter.transform.position.x, this.shooter.transform.position.y, this.shooter.transform.position.z);
        //Vector3 rotation = new Vector3(shooter.transform.rotation.x, shooter.transform.rotation.y, shooter.transform.rotation.z);


        if (Input.GetKey(KeyCode.Space))
        {

            //GameObject clone = Instantiate(bullet, position, Quaternion.identity);

            GameObject clone = Instantiate(bullet, position, shooter.transform.rotation);

            //GameObject clone = Instantiate(bullet, new Vector3(this.shooter.transform.position.x, this.shooter.transform.position.y, this.shooter.transform.position.z), Quaternion.identity);

            //GameObject clone = Instantiate(bullet, position, transform.rotation);




        }

       bullets = GameObject.FindGameObjectsWithTag("bullet");
       foreach (GameObject bullet in bullets)

       {
            

            bullet.transform.Translate(transform.forward * Time.deltaTime * 7f, Space.Self);

           //bullet.transform.Translate(Vector3.MoveTowards(position, rotation, 10f) * Time.deltaTime * 2f, Space.Self);

            //bullet.transform.Translate(Vector3.forward * Time.deltaTime * 2f);


            // transform.Translate(new Vector3(shooter.transform.position.x, shooter.transform.position.y, shooter.transform.position.z) * Time.deltaTime * 2f);



        }
    }
}
