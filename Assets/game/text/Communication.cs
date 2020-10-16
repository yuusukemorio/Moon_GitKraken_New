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


    string CCscript;
    public Camera_Collision CameraC;


    void Start()
    {
        textData = textFile.text;
        splitText = textData.Split(char.Parse("\n"));// 改行で分割して配列に代入
    }


    void Update()
    {
        CCscript = CameraC.nani_hureta;
        TimeCount += Time.deltaTime;
        Debug.Log(TimeCount);
        if (CCscript == "Communication1")
        {
            for (int x = 0; x <= 8; x++) //正直よろしくない処理。何回セリフを喋らすかをマジックナンバーを用いて手動で入力している。
            {
                SpeakTime = float.Parse(splitText[TextCount].Substring(0, 3));//最初から三番目までの文字をint型に変換する。
                textLabel.text = splitText[TextCount].Substring(4, splitText[TextCount].Length - 4);//配列からTextCoun番目の要素の4番目から全体の長さ-4した場所を求める

                if (TimeCount >= SpeakTime)
                {
                    TextCount += 1;
                    TimeCount = 0;
                }
            }
        }

        //Communication_IVSG("Communication1", 8);//OP,おはよ
        //Communication_IVSG("Communication2", 12);//今日も...行くの?
        //Communication_IVSG("Communication3", 18);//宇宙服の点検嫌!&アナログっていいよね
        //Communication_IVSG("Communication4", 6);//エネルギー残量大丈夫?
        //Communication_IVSG("Communication5", 34);//スグって読むねんで&分析家結果&映画のセリフ言い合い
        //Communication_IVSG("Communication6", 3);//地下街やな嫌いやわ...
        //Communication_IVSG("Communication7", 6);//ネオン消えへんな...
        //Communication_IVSG("Communication8", 10);//核兵器の記録見つかったで
        //Communication_IVSG("Communication9", 9);//ED,最深部ついたぜ!

    }

    void Communication_IVSG(string a, int b)
    {
        if (CCscript == a)
        {
            TimeCount = 0;
            for (int x = 0; x <= b; x++) //正直よろしくない処理。何回セリフを喋らすかをマジックナンバーを用いて手動で入力している。
            {
                SpeakTime = float.Parse(splitText[TextCount].Substring(0, 3));//最初から三番目までの文字をint型に変換する。
                textLabel.text = splitText[TextCount].Substring(4, splitText[TextCount].Length - 4);//配列からTextCoun番目の要素の4番目から全体の長さ-4した場所を求める

                if (TimeCount >= SpeakTime)
                {
                    TextCount += 1;
                    TimeCount = 0;
                }
            }
        }
    }
}
