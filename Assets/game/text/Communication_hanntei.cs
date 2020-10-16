using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Communication_hanntei : MonoBehaviour
{

    public string nani_hureta;

    void OnCollisionEnter(Collision other)
    {

        //Debug.Log(other.gameObject.name);
        nani_hureta = other.gameObject.name;
    }
}
