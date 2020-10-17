using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textcollor : MonoBehaviour
{
    public Camera_Collision CameraC;
    string CCscript;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        CCscript = CameraC.nani_hureta;
        if(CCscript == "black")
        {
            gameObject.GetComponent<Text>().color = new Color(0, 0, 0, 1);
            Debug.Log("黒");
        }
        else if (CCscript == "white")
        {
            gameObject.GetComponent<Text>().color = new Color(1, 1, 1, 1);
            Debug.Log("白");
        }
    }
}
