using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enerugi_scene : MonoBehaviour
{

    public string huretakaEnerugi = "no";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "iv")
        {
            //ChangeScene();
            huretakaEnerugi = "yes";
            Debug.Log(huretakaEnerugi);
        }
    }
}

