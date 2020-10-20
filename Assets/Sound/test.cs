using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private AudioSource audioSource;
    public Camera_Collision CameraC;
    string CCscript;

    float VolumeTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        CCscript = CameraC.nani_hureta;

        Debug.Log(CCscript);
        Debug.Log("CCscript");

        if (CCscript == "kurayami3_out")
        {
            VolumeTime = Time.deltaTime / 4;
            if (audioSource.volume >= 0)
            {
                audioSource.volume -= VolumeTime;
                Debug.Log(audioSource.volume);
            }
        }
    }
}
