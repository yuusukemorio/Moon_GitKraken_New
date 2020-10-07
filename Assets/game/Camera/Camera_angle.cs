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
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(0,1,1.2f);
        }
        if (CCscript == "hall_out")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = -0.4f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(-20f, 1, 1.2f);
        }

        if (CCscript == "tuuro_in")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = -0.3f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(-20f, 1, 1.2f);
        }
        if (CCscript == "tuuro_out")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0.3f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(0, 1, 1.2f);
        }
    }
}
