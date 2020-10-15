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

    float SpeakTime = 0.0f;


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
        for (int x = 0; x <= 10; x++) //正直よろしくない処理。何回セリフを喋らすかをマジックナンバーを用いて手動で入力している。
        {
            SpeakTime = float.Parse(splitText[TextCount].Substring(0, 3));//最初から三番目までの文字をint型に変換する。
            if (TimeCount >= SpeakTime)
            {
                Speaking();
                TimeCount = 0;
            }
        }
    }

    void Speaking()
    {
        textLabel.text = splitText[TextCount];//textに表示
        TextCount = TextCount + 1;//セリフの順番

    }
}
