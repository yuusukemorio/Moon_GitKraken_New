using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camera_Collision : MonoBehaviour
{
    public string nani_hureta;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {

        //Debug.Log(other.gameObject.name);
        nani_hureta = other.gameObject.name;
    }
}