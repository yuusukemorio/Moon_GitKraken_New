using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{

    string ud = "up";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
        //Transform myTransform = this.transform;

        if (Input.GetKeyDown(KeyCode.UpArrow) && ud == "down")
        {
            //this.transform.rotation = Quaternion.Euler(0, 0, 0);
            this.transform.Rotate(new Vector3(0f, 180f, 0f));
            ud = "up";
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && ud == "up")
        {
           //this.transform.rotation = Quaternion.Euler(0, 180, 0);
            this.transform.Rotate(new Vector3(0f, 180f, 0f));
            ud = "down";
        }
        else
        {
        }
    }
}
