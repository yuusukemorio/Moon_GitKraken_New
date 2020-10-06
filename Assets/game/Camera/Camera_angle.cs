using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Camera_angle : MonoBehaviour
{
    public Camera_Collision CameraC;
    CinemachineVirtualCamera CVcamera;
    //public GameObject camera_hanntei;

    string CCscript;

    void Start()
    {
        //camera_hanntei = GameObject.Find("camera_hanntei");
        //CCscript = camera_hanntei.GetComponent<Camera_Collision> ();

        CVcamera = this.gameObject.GetComponent<CinemachineVirtualCamera>();

    }


    void Update()
    {
        CCscript = CameraC.nani_hureta;

        //Debug.Log(CCscript);
        if (CCscript == "hall_in")
        {
            CVcamera.Priority = 40;
        //    Debug.Log("hallin");
        }
        if (CCscript == "hall_out")
        {
        //    Debug.Log("Hello");
        }

        if (CCscript == "tuuro_in")
        {
        //    Debug.Log("Hello");
        }
        if (CCscript == "tuuro_out")
        {
        //    Debug.Log("Hello");
        }
    }
}
