using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tiitle2 : MonoBehaviour

{
    float count = 0.0f;
    float timeLimit = 2.5f;
    TextImput2 script;
    GameObject PROGRAM;

    // Start is called before the first frame update
    void Start()
    {
        PROGRAM = GameObject.Find("PROGRAM");
        script = PROGRAM.GetComponent<TextImput2>();
        //CanvasGroup CG = this.GetComponent<CanvasGroup>();

    }
    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;

        if (count >= timeLimit)
        {
            //CG.alpha = 0;
            this.GetComponent<CanvasGroup>().alpha = 0;
        }

        if (script.pattern == "4")//シーンへの移行の処理。なんでこんなコード書いたんや...
        {
            this.GetComponent<CanvasGroup>().alpha = 1;

            SceneManager.LoadScene("Game");
        }
    }
}
