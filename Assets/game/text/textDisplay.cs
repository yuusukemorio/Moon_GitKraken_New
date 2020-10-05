using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textDisplay : MonoBehaviour
{

    public string[] texts;
    int textNumber = 0;

    void Start()
    {
        
    }

    void Update()
    {

        this.GetComponent<Text>().text = texts[textNumber];
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            textNumber = textNumber + 1;

        }
    }
}
