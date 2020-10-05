using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tiitle : MonoBehaviour

{
    float count = 0.0f;
    float timeLimit = 2.5f;
    TextImput script;
    GameObject PROGRAM;

    // Start is called before the first frame update
    void Start()
    {
        PROGRAM = GameObject.Find("PROGRAM");
        script = PROGRAM.GetComponent<TextImput>();
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

        if (script.pattern == "3")
        {
            this.GetComponent<CanvasGroup>().alpha = 1;

            SceneManager.LoadScene("Game");
        }
    }
}
