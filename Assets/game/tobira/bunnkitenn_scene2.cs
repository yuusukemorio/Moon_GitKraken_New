using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bunnkitenn_scene2 : MonoBehaviour
{

    public string huretaka2 = "no";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "iv")
        {
            //ChangeScene();
            huretaka2 = "yes";
            Debug.Log(huretaka2);
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Hacking");
    }
}

