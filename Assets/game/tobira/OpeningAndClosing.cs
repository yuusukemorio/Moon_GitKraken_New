using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningAndClosing : MonoBehaviour
{

    public float speed;
    public float stop;
    public string direction_LorR;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
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