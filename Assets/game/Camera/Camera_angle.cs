using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Camera_angle : MonoBehaviour
{
    public Camera_Collision CameraC;
    //public GameObject camera_hanntei;

    string CCscript;

    void Start()
    {
        //camera_hanntei = GameObject.Find("camera_hanntei");
        //CCscript = camera_hanntei.GetComponent<Camera_Collision> ();

        CinemachineVirtualCamera CVcamera = this.gameObject.GetComponent<CinemachineVirtualCamera>();

        CCscript = CameraC.nani_hureta;
    }


    void Update()
    {
        if (CCscript == "hall_in")
        {
            //CVcamera.Priority = 40;
            Debug.Log("Hello");
        }
        if (CCscript == "hall_out")
        {
            Debug.Log("Hello");
        }

        if (CCscript == "tuuro_in")
        {
            Debug.Log("Hello");
        }
        if (CCscript == "tuuro_out")
        {
            Debug.Log("Hello");
        }
    }
}
