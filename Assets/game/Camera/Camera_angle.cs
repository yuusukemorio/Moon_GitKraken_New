using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Camera_angle : MonoBehaviour
{
    Camera_Collision CCscript;
    GameObject camera_hanntei;

    void Start()
    {
        camera_hanntei = GameObject.Find("camera_hanntei");
        CCscript = camera_hanntei.GetComponent<Camera_Collision> ();

        CinemachineVirtualCamera CVcamera = this.gameObject.GetComponent<CinemachineVirtualCamera>();
    }


    void Update()
    {
        if (CCscript.nani_hureta == "hall_in")
        {
            CVcamera.Priority = 40;
            Debug.Log("Hello");
        }
        if (CCscript.nani_hureta == "hall_out")
        {
            Debug.Log("Hello");
        }

        if (CCscript.nani_hureta == "tuuro_in")
        {
            Debug.Log("Hello");
        }
        if (CCscript.nani_hureta == "tuuro_out")
        {
            Debug.Log("Hello");
        }
    }
}
