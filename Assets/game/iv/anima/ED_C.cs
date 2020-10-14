using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ED_C : MonoBehaviour
{

    public Camera_Collision CameraC;
    string CCscript;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        CCscript = CameraC.nani_hureta;
       
        if (CCscript == "rasuto")
        {
            SceneManager.LoadScene("ED");
        }
    }
}
