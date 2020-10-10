using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{

    public string[] texts;
    int textNumber = 0;
    float TimeCount = 0.0f;

                          //0  1     2     3     4     5     6     7     8     9     10    11    12    13  14  15    16  17  18    19  20  21    22    23    24    25    26    27
    float[] DisplayTime = { 0, 3.5f, 3.5f, 3.5f, 3.5f, 3.5f, 3.5f, 3.5f, 3.5f, 3.5f, 3.5f, 3.5f, 3.5f, 4f, 4f, 3.5f, 4f, 4f, 3.5f, 4f, 4f, 3.5f, 3.5f, 3.5f, 3.5f, 3.5f, 3.5f, 3.5f};

    void Start()
    {

    }

    void Update()
    {
        TimeCount += Time.deltaTime;
        if (TimeCount >= DisplayTime[textNumber])
        {
            Speaking();
            TimeCount = 0;
        }
    }

    void Speaking()
    {
        this.GetComponent<Text>().text = texts[textNumber];
        textNumber = textNumber + 1;

    }
}
