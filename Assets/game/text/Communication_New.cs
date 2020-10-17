using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Communication_New : MonoBehaviour
{
    public Text textLabel;
    [SerializeField]
    private TextAsset textFile;
    private string textData;
    private string[] splitText;

    float SpeakTime = 0.0f;
    int TextCount = 0;
    float TimeCount = 0.0f;
    float DeleteTimeCount = 0.0f;

    public Communication_New_Text CNT;
    string CNTscript;

    string[] hureta_Name = {"Communication1", "Communication2", "Communication3", "Communication4", "Communication5", "Communication6", "Communication7", "Communication8", "Communication9", "end" };
    int Count_Name = 0;

    // Start is called before the first frame update
    void Start()
    {
        textData = textFile.text;
        splitText = textData.Split(char.Parse("\n"));
    }

    // Update is called once per frame
    void Update()
    {
        CNTscript = CNT.Communication_name;
        Debug.Log(TimeCount);

        if (CNTscript == hureta_Name[Count_Name])
        {
            //communication(8);
            TimeCount += Time.deltaTime;
            DeleteTimeCount += Time.deltaTime;
            Debug.Log(DeleteTimeCount);

            SpeakTime = float.Parse(splitText[TextCount].Substring(0, 3));//最初から三番目までの文字をint型に変換する。
            if (TimeCount >= SpeakTime)
            {
                textLabel.text = splitText[TextCount].Substring(4, splitText[TextCount].Length - 4);//配列からTextCoun番目の要素の4番目から全体の長さ-4した場所を求める
                TextCount += 1;
                TimeCount = 0;
            }
            if (Count_Name == 0)
            {
                if (DeleteTimeCount >= 3.5 * 7 + 6)//ここの処理最悪。結局諦めてサブで計測して、特定の数値になったらストップするようにした。
                {
                    Count_Name++;
                    DeleteTimeCount = 0;
                }
            }
            if (Count_Name == 1)
            {
                if (DeleteTimeCount >= 3.5 * 5 + 5.5*7)//ここの処理最悪。結局諦めてサブで計測して、特定の数値になったらストップするようにした。
                {
                    Count_Name++;
                    DeleteTimeCount = 0;
                }
            }
            if (Count_Name == 2)
            {
                if (DeleteTimeCount >= 3.5 * 18 + 1)//ここの処理最悪。結局諦めてサブで計測して、特定の数値になったらストップするようにした。
                {
                    Count_Name++;
                    DeleteTimeCount = 0;
                }
            }
        }
    }

    void communication(int a)
    {
        TimeCount += Time.deltaTime;
        for (int x = 0; x <= a; x++) //正直よろしくない処理。何回セリフを喋らすかを手動で入力している。
        {
            if (TimeCount >= SpeakTime)
            {
                SpeakTime = float.Parse(splitText[TextCount].Substring(0, 3));//最初から三番目までの文字をint型に変換する。
                textLabel.text = splitText[TextCount].Substring(4, splitText[TextCount].Length - 4);//配列からTextCoun番目の要素の4番目から全体の長さ-4した場所を求める

                TextCount += 1;
                TimeCount = 0;
            }
        }
    }
}
