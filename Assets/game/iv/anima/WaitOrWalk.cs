using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitOrWalk : MonoBehaviour
{

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()

    {
        Transform myTransform = this.transform;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("waitwalk",true);
            //myTransform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("waitwalk", true);
            //myTransform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            anim.SetBool("waitwalk", false);
        }
    }
}
