using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugConsole : MonoBehaviour
{
    GameObject Pprogram;

    TextImput Pscript;

    string DEBUG;
    int Ttime = 0;

    // Start is called before the first frame update
    void Start()
    {
        Pprogram = GameObject.Find("PROGRAM");
        Pscript = Pprogram.GetComponent<TextImput>();
    }

    // Update is called once per frame
    void Update()
    {

        DEBUG = Pscript.DebugConsoleERROR;
        this.GetComponent<Text>().text = DEBUG;

    }

    void dandan()
    {
        for (int x = 0; x <= 500; x++)
        {
            Ttime++;
            if (Ttime % 30 == 0)
            {

                DEBUG = DEBUG + Pscript.DebugConsoleERROR.Substring(x);
                this.GetComponent<Text>().text = DEBUG;
            }
        }
    }
}
