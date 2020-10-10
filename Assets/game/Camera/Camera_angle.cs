using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Camera_angle : MonoBehaviour
{
    public Camera_Collision CameraC;
    CinemachineVirtualCamera CVcamera;
    //public GameObject camera_hanntei;

    //public AnimationCurve angleCurve;
    //float angleTime;

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

        if (CCscript == "paipu_in")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(3, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, 1.7f, -13.4f);
            //CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, 1.7f, -13.4f);
        }
        if (CCscript == "paipu_out")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = transform.position = new Vector3(0, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, 1.7f, -13.4f);
            //CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, 2.02f, -13.4f);
        }




        if (CCscript == "hall_in")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(0, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, 1.7f, -13.4f);
            //CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, 2.02f, -13.4f);

        }
        if (CCscript == "hall_out")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = -0.3f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = transform.position = new Vector3(-20f, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, 1.7f, -13.4f);
            //CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, 1.7f, -13.4f);

        }



        if (CCscript == "tuuro_in")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = -0.3f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(-20f, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, 1.7f, -13.4f);
        }
        if (CCscript == "tuuro_out")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0.3f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(2.06f, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, 1.7f, -13.4f);
        }



        if (CCscript == "tuuro2_in")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0.3f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(2.06f, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, 1.7f, -13.4f);
        }
        if (CCscript == "tuuro2_out")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(0, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, 1.7f, -13.4f);
        }



        if (CCscript == "taiki-1_in")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(0, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, 1.7f, -13.4f);
        }
        if (CCscript == "taiki-1_out")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0.3f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(0, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, 0.4f, -13.4f);
        }
        if (CCscript == "taiki-0.5_in")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0.3f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(0, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, 0.4f, -13.4f);
        }
        if (CCscript == "taiki-0.5_out")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0.8f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(0, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, 0.4f, -13.4f);
        }
        if (CCscript == "taiki_in")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0.8f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(0, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, 0.4f, -13.4f);
        }
        if (CCscript == "taiki_out")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 1.04f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(2.06f, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, -0.64f, -13.4f);
        }
        if (CCscript == "taiki2_in")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 1.04f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(2.06f, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, -0.64f, -13.4f);
        }
        if (CCscript == "taiki2_out")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0.8f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(0, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, -0.64f, -13.4f);
        }
        if (CCscript == "taiki3_in")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0.8f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(0, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(3, -0.64f, -13.4f);
        }
        if (CCscript == "taiki3_out")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(0, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(0, 1.7f, -13.4f);
        }



        if (CCscript == "hatudenn_in")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(0, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(0, 1.7f, -13.4f);
        }
        if (CCscript == "hatudenn_out")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(-17.66f, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(10.57f, 3f, -13.4f);
        }



        if (CCscript == "kuraituuro_in")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(-17.66f, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(10.57f, 3f, -13.4f);
        }
        if (CCscript == "kuraituuro_out")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(0, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(4f, 0, -13.4f);
        }



        if (CCscript == "tikagai_in")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(0, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(4f, 0, -13.4f);
        }
        if (CCscript == "tikagai_out")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(-1.49f, 2.3f, 0);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(-0.43f, 1.53f, -9.8f);
        }
        if (CCscript == "tikagai2_in")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = 0;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(-1.49f, 2.3f, 0);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(-0.43f, 1.53f, -9.8f);
        }
        if (CCscript == "tikagai2_out")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = -0.045f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(-3.8f, 4.51f, 0);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(0.05f, -5.45f, -9.8f);
        }
        if (CCscript == "tikagai3_in")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = -0.045f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(-3.8f, 4.51f, 0);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(0.05f, -5.45f, -9.8f);
        }
        if (CCscript == "tikagai3_out")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = -0.44f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(3, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(0, 0, 0);
        }

        if (CCscript == "kurayami_in")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = -0.44f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(3, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(0, 0, 0);
        }
        if (CCscript == "kurayami_out")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = -0.44f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(0, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(0, 0, 0);
        }
        if (CCscript == "kurayami2_in")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = -0.44f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(0, 1, 1.2f);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(0, 0, 0);
        }
        if (CCscript == "kurayami2_out")
        {
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_AutoDolly.m_PositionOffset = -0.44f;
            CVcamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = new Vector3(-5.67f, 1, 0);
            CVcamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathOffset = new Vector3(-0.72f, 0, 0);
        }
    }
}
