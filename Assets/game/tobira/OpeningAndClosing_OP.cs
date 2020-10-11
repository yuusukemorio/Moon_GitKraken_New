using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningAndClosing_OP : MonoBehaviour
{

    public float speed;
    public float stop;
    public string direction_LorR;

    string BSscriptOP;
    public bunnkitenn_scene_OP bunnkitennOP;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        BSscriptOP = bunnkitennOP.huretakaOP;

        if (BSscriptOP == "yes")
        {
            if (direction_LorR == "L")
            {
                if (transform.position.z <= stop)
                {
                    transform.position = transform.position + new Vector3(0, 0, speed);
                }
            }

            else if (direction_LorR == "R")
            {
                if (transform.position.z >= stop)
                {
                    transform.position = transform.position + new Vector3(0, 0, speed);
                }
            }
        }
    }
}