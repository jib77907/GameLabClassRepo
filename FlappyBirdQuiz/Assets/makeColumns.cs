using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class makeColumns : MonoBehaviour
{

    public GameObject upColumn;

    float timer = 0;

    GameObject[] upColumns;

    public float count;
    public Text countText;

    // Use this for initialization
    void Start()
    {
        count = 0;
        countText.text = "Count:" + count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        if (timer >= 2.2f)
        {

            Instantiate(upColumn, (new Vector2(17f, Random.Range(4.5f, 7.5f))), Quaternion.identity);

            timer = 0;

        }

        upColumns = GameObject.FindGameObjectsWithTag("UPcolumn");
        foreach (GameObject upColumn in upColumns)
        {
            upColumn.transform.localPosition = new Vector2(upColumn.transform.localPosition.x - 0.03f, upColumn.transform.localPosition.y);

            if (upColumn.transform.localPosition.x <= -1.1f && upColumn.transform.localPosition.x >= -1f)
            {
                count = count +1;
               
                SetCountText();

            }

            if (upColumn.transform.localPosition.x <= -9f)
            {
                Destroy(upColumn);

            }
        }


    }

    void SetCountText()
    {
        countText.text = "Count:" + count.ToString();
    }
}
