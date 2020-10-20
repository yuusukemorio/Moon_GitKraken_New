
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMdown : MonoBehaviour
{
    private AudioSource audioSource;
    public Camera_Collision CameraC;
    string CCscript;

    float VolumeTime = 0;

    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    void Upadate()
    {
        CCscript = CameraC.nani_hureta;

        Debug.Log(CCscript);
        Debug.Log("CCscript");

        if (CCscript == "kurayami3_out")
        {
            VolumeTime = Time.deltaTime / 5;
            if (audioSource.volume >= 0)
            {
                audioSource.volume -= VolumeTime;
                Debug.Log(audioSource.volume);
            }
        }
    }
}