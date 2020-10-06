using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{

    public string[] texts;
    int textNumber = 0;
    float TimeCount = 0.0f;

                          //0  1  2  3  4  5  6  7  8  9   10 11 12 13 14 15 16
    float[] DisplayTime = { 0, 5, 5, 5, 5, 5, 5, 5, 5, 10, 5, 5, 5, 5, 5, 5, 10};

    void Start()
    {

    }

    void Update()
    {
        TimeCount += Time.deltaTime;
        Debug.Log(TimeCount);
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
