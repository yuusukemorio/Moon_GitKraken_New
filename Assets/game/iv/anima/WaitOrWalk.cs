using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitOrWalk : MonoBehaviour
{

    private Animator anim;
    private Transform TF;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        TF = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()

    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("waitwalk",true);
            this.transform.rotation = Quaternion.Euler(0,90,0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("waitwalk", true);
            this.transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        else
        {
            anim.SetBool("waitwalk", false);
        }
    }
}
