using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextImput : MonoBehaviour
{

    string[] keyboard_ABC = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
    string[] RandomCode = {"MOV AL, 1h      ; Load AL with immediate value 1",
        "PUBLIC  $&RESWRD",
        "CLIPPL=PC8A OR TRSER2 OR MODEL3",
        "DSEG A,B,X,U",
        "A=$80",
        "[Tt]est[Rr]esult*/" ,
        "OMMENA,[Rr]esult*/Load AL with MOV AL, 1h EG APOINT(X,YATTRIBUTE)COMMENT",
        "        extrn   RESWRD:NEAR",
        "             [Dd]ebugPS/",
        "\n",
        "COMMENT	*",
        "	CMP	AL,LOW OFFSET $STEP",
        "	JZ	SHORT SCYREL",
        "; POINT(X,Y) RETURNS THE ATTRIBUTE STORED AT THAT POINT",
        "FIRST:	CALL	MAKINT",
        "STANLEY KUBRICK    2001: A SPACE ODYSSEY",
        "	CMP	AL,LOW OFFSET $STEP",};

    string KeyBoard_Input = "Normal";
    public string pattern = "1";
    public string DebugConsoleERROR;
    string program;
    int TextSpeedTime = 0;
    string ImputCode;
    int RandomFor;
    int TextSpeed = 150;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (KeyBoard_Input == "TrueOrFels")
        {
            if (pattern == "1" && ImputCode == "raybeq")
            {
                umakuittaka();
                DebugConsoleERROR = "ACCESS GRANTED";

                pattern = "2";
            }
            else if(pattern == "2" && ImputCode == "open door")
            {
                umakuittaka();
                DebugConsoleERROR = "UNLOCKED";
                pattern = "3";
            }
            else
            {
                umakuittaka();
                DebugConsoleERROR = "ERROR";
            }
            
        }


        if (KeyBoard_Input == "Random")
        {
            for (int x = 0; x <= RandomFor; x++)
            {
                TextSpeedTime++;
                if (TextSpeedTime % TextSpeed == 0)
                {
                    program = program + RandomCode[Random.Range(1, RandomCode.Length)];
                    program = program + "\n";
                    this.GetComponent<Text>().text = program;
                }
                if (RandomFor == TextSpeedTime / TextSpeed)
                {
                    KeyBoard_Input = "TrueOrFels";
                }
            }
            //KeyBoard_Input = "TrueOrFels";
        }


        if (KeyBoard_Input == "Normal")
        {
            for (int x = 0; x <= keyboard_ABC.Length - 1; x++)
            {
                if (Input.GetKeyDown(keyboard_ABC[x]))
                {
                    program = program + keyboard_ABC[x];
                    ImputCode = ImputCode + keyboard_ABC[x];

                    this.GetComponent<Text>().text = program;
                    Debug.Log(ImputCode);
                }
            }

            if (Input.GetKeyDown("space"))
            {
                program = program + " ";
                ImputCode = ImputCode + " ";

                this.GetComponent<Text>().text = program;
            }
            //if (Input.GetKeyDown("backspace"))
            //{
            //    program = program.Substring(0, program.Length - 1);
            //    this.GetComponent<Text>().text = program;
            //}
            if (Input.GetKeyDown("return"))
            {
                program = program + "\n";
                program = program + "----------------------------------------------------------------------------------------";
                program = program + "\n";
                this.GetComponent<Text>().text = program;
                RandomFor = Random.Range(50, 100);
                TextSpeedTime = 0;
                KeyBoard_Input = "Random";

            }
        }
    }

    void umakuittaka()
    {
        program = program + "----------------------------------------------------------------------------------------";
        program = program + "\n";
        this.GetComponent<Text>().text = program;
        //        program = program + "\n";
        //        program = program + "----------------------------------------------------------------------------------------";
        //        program = program + "\n";
        //
        //        if (ImputCode == "open door")
        //        {
        //            program = program + "AccessGranted";
        //        }
        //        else
        //        {
        //            program = program + "AccessDenied";
        //        }

        KeyBoard_Input = "Normal";
        program = program + "\n";
        program = program + "\n";
        ImputCode = "";
    }
}