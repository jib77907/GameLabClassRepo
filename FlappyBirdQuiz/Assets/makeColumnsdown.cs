using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeColumnsdown : MonoBehaviour {

    public GameObject downColumn;

    float timer = 0;

    GameObject[] downColumns;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        if (timer >= 2.2f)
        {

            Instantiate(downColumn, (new Vector2(17f, Random.Range(-6f, -3f))), Quaternion.identity);

            timer = 0;

        }

        downColumns = GameObject.FindGameObjectsWithTag("DOWNcolumn");
        foreach (GameObject downColumn in downColumns)
        {
            downColumn.transform.localPosition = new Vector2(downColumn.transform.localPosition.x - 0.03f, downColumn.transform.localPosition.y);

            if (downColumn.transform.localPosition.x <= -9f)
            {
                Destroy(downColumn);

            }
        }
    }
}
