using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningAndClosing : MonoBehaviour
{

    public float speed;
    public float stop;
    public string direction_LorR;

    string BSscript;
    public bunnkitenn_scene bunnkitenn;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        BSscript = bunnkitenn.huretaka;

        if (BSscript == "yes")
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