using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bunnkitenn_scene : MonoBehaviour
{

    public string huretaka = "no";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "iv")
        {
            //ChangeScene();
            huretaka = "yes";
            Debug.Log(huretaka);
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Hacking");
    }
}

