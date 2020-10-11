using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningAndClosing_enerugi : MonoBehaviour
{
    public float speed;
    public float stop;
    public string direction_LorR;

    string BSscriptEnerugi;
    public enerugi_scene bunnkitennEnerugi;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        BSscriptEnerugi = bunnkitennEnerugi.huretakaEnerugi;

        if (BSscriptEnerugi == "yes")
        {
            if (direction_LorR == "L")
            {
                if (transform.position.x <= stop)
                {
                    transform.position = transform.position + new Vector3(speed, 0, 0);
                }
            }

            else if (direction_LorR == "R")
            {
                if (transform.position.x >= stop)
                {
                    transform.position = transform.position + new Vector3(speed, 0, 0);
                }
            }
        }
    }
}