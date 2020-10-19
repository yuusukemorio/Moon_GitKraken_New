using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cursor : MonoBehaviour
{
    RectTransform rect;
    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
        rect.localPosition = new Vector3(-20.49f, -25.49f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rect.localPosition = new Vector3(-20.49f, -25.49f, 0);
            //this.transform.position = new Vector3(-20.49f, -25.49f, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rect.localPosition = new Vector3(-38.9f, -78.1f, 0);
            //this.transform.position = new Vector3(-38.9f, -78.1f, 0);
        }
    }
}
