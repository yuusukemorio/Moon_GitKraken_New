using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Communication : MonoBehaviour
{
    //[SerializeField]
    public Text textLabel;
   //[SerializeField]
    public TextAsset textFile;

    private string textData;
    private string[] splitText;

    int TextCount = 0;
    float TimeCount = 0.0f;


    void Start()
    {
        textData = textFile.text;

        // 改行で分割して配列に代入
        splitText = textData.Split(char.Parse("\n"));
        // テキストデータの先頭文字列（１行目）を表示する
        textLabel.text = splitText[0];
    }


    void Update()
    {
        TimeCount += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (TimeCount >= DisplayTime[textNumber])
            {
                Speaking();
                TimeCount = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (TimeCount >= DisplayTime[textNumber])
            {
                Speaking();
                TimeCount = 0;
            }
        }
    }

    void Speaking()
    {
        textLabel.text = splitText[TextCount];
        TextCount = TextCount + 1;

    }
}
