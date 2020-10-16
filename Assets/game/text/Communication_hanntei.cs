using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Communication_hanntei : MonoBehaviour
{
    [SerializeField]
    private Text textLabel;

    [SerializeField]
    private TextAsset textFile;

    private string textData;
    private string[] splitText;

    float SpeakTime = 0.0f;

    int TextCount = 0;
    float TimeCount = 0.0f;

    void Start()
    {
        textData = textFile.text;

        splitText = textData.Split(char.Parse("\n"));
    }

    void Update()
    {
        TimeCount += Time.deltaTime;
        Debug.Log(TimeCount);
    }



    void OnCollisionEnter(Collision other)
    {
        Communication_IVSG("Communication1", 8, other.gameObject.name);//OP,おはよ
        Communication_IVSG("Communication2", 12, other.gameObject.name);//今日も...行くの?
        Communication_IVSG("Communication3", 18, other.gameObject.name);//宇宙服の点検嫌!&アナログっていいよね
        Communication_IVSG("Communication4", 6, other.gameObject.name);//エネルギー残量大丈夫?
        Communication_IVSG("Communication5", 34, other.gameObject.name);//スグって読むねんで&分析家結果&映画のセリフ言い合い
        Communication_IVSG("Communication6", 3, other.gameObject.name);//地下街やな嫌いやわ...
        Communication_IVSG("Communication7", 6, other.gameObject.name);//ネオン消えへんな...
        Communication_IVSG("Communication8", 10, other.gameObject.name);//核兵器の記録見つかったで
        Communication_IVSG("Communication9", 9, other.gameObject.name);//ED,最深部ついたぜ!
    }



    void Communication_IVSG(string a, int b, string c)
    {
        if (c == a)
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
