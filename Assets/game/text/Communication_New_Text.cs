using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Communication_New_Text : MonoBehaviour
{

    public string Communication_name;

    void OnTriggerEnter(Collider collision)
    {
        Communication_name = collision.gameObject.name;
    }
}
