using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bunnkitenn_scene_OP : MonoBehaviour
{

    public string huretakaOP = "no";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "iv")
        {
            //ChangeScene();
            huretakaOP = "yes";
            Debug.Log(huretakaOP);
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Hacking");
    }
}

