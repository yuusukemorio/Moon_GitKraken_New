using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cursor1 : MonoBehaviour
{
    RectTransform rect;
    string ud = "up";
    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
        rect.localPosition = new Vector3(-10.92775f, -367.6187f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (clear.GameClear == "yes") {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rect.localPosition = new Vector3(-10.92775f, -367.6187f, 0);
                ud = "up";
                //this.transform.position = new Vector3(-20.49f, -25.49f, 0);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rect.localPosition = new Vector3(-100f, -615.5665f, 0);
                ud = "down";
                //this.transform.position = new Vector3(-38.9f, -78.1f, 0);
            }

            if (Input.GetKeyDown(KeyCode.Return) && ud == "down")
            {
                SceneManager.LoadScene("Postscript");
            }
            if (Input.GetKeyDown(KeyCode.Return) && ud == "up")
            {
                SceneManager.LoadScene("preface");
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("preface");
            }
        }
    }
}
